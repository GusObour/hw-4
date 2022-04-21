using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextAnalysis
{
    public partial class uxTextAnalyzer : Form
    {
        
        public uxTextAnalyzer()
        { 
            InitializeComponent();
            uxAllFilesListView.ListViewItemSorter = _allFilesColumnSorter;
            SortColumn(uxAllFilesListView, _allFilesHeadings,_fileNameColumn,SortOrder.None);
            uxSelectedListView.ListViewItemSorter = _selectedColumnSorter;
            SortColumn(uxSelectedListView, _selectedHeadings, _wordColumn, SortOrder.None);
        }
        private const int _fileNameColumn = 0;
        private const int _wordColumn = 0;
        private const int _differenceColumn = 2;
        private const string _differenceFormat = "N5";
        private const string _frequencyFormat = "N5";
        private const int _vocabularyWidth = 10;
        private string[] _allFilesHeadings = { "File Name", "Vocabulary", "Difference" };
        private string[] _selectedHeadings = { "Word", "Frequency"};
        private string[] _headingSuffixes = { "   ", "  ˆ", "  ˇ" };
        ListViewColumnSorter _allFilesColumnSorter= new ListViewColumnSorter();
        ListViewColumnSorter _selectedColumnSorter = new ListViewColumnSorter();
        Dictionary<string, Dictionary<string, float>> _frequencyTabels;
        private void SortColumn(ListView lv, string [] headings, int columnHeading, SortOrder sort)
        {
            ListViewColumnSorter temp = (ListViewColumnSorter)lv.ListViewItemSorter;
            temp.SortColumn = columnHeading;
            temp.Order = sort;
            if(sort != SortOrder.None)
            {
                lv.Sort();
            }
            for(int i=0; i<lv.Columns.Count;i++)
            {
                if(i == columnHeading)
                {
                    lv.Columns[i].Text = headings[i] + _headingSuffixes[(int)sort];
                }
                else
                {
                    lv.Columns[i].Text = headings[i] + _headingSuffixes[(int)SortOrder.None];
                }
            }
        }
        private void reverseSort(ColumnClickEventArgs e, ListView lv, string[] headings)
        {
            ListViewColumnSorter temp = (ListViewColumnSorter)lv.ListViewItemSorter;
            SortOrder order = SortOrder.Ascending;
            if(e.Column == temp.SortColumn) 
            {
                if(temp.Order == SortOrder.Ascending)
                {
                    order = SortOrder.Descending;
                }
                else
                {
                    order = SortOrder.Ascending;
                }

            }
            SortColumn(lv, headings, e.Column, order);
        }
        private void uxOpenfile_Click(object sender, EventArgs e)
        {

            if (uxBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    uxTabControl.SelectTab(uxAllFiles);
                    _frequencyTabels = Analyzer.GetFreqTabel(uxBrowserDialog.SelectedPath);
                    uxTextBox.Text = "";
                    foreach(KeyValuePair<string, Dictionary<string, float>> temp in _frequencyTabels )
                    {
                        ListViewItem fn = new ListViewItem(temp.Key);
                        fn.SubItems.Add($"{temp.Value.Count,_vocabularyWidth }");
                        fn.SubItems.Add("");
                        uxAllFilesListView.Items.Add(fn);
                    }
                    SortColumn(uxAllFilesListView, _allFilesHeadings, _fileNameColumn, SortOrder.Ascending);
                    uxSelectedListView.Items.Clear();
                    SortColumn(uxSelectedListView, _selectedHeadings, _wordColumn, SortOrder.None);
                }
                catch
                {
                    MessageBox.Show("Error Occurred");
                }
            }
                
        }

        private void uxAllFilesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxSelectedListView.BeginUpdate();
            uxSelectedListView.Items.Clear();
            if (uxAllFilesListView.SelectedItems.Count > 0)
            {
                uxTextBox.Text = uxAllFilesListView.SelectedItems[0].Text;
                ListViewItem selectedFile = uxAllFilesListView.SelectedItems[0];
                Dictionary<string, float> selected = _frequencyTabels[selectedFile.Text];
                foreach (ListViewItem fn in uxAllFilesListView.Items)
                {
                    Dictionary<string, float> temp = _frequencyTabels[fn.Text];
                    float diff = Analyzer.Difference(selected,temp, (int)uxNumericUpDown.Value);
                    fn.SubItems[_differenceColumn].Text = diff.ToString(_differenceFormat);
                   
                }
                if(_frequencyTabels.ContainsKey(uxTextBox.Text))
                {
                    Dictionary<string, float> selectedWords= _frequencyTabels[uxTextBox.Text];
                    foreach (string words in selectedWords.Keys)
                    {
                        if((decimal)selectedWords[words] >= uxThreshold.Value)
                        {
                            ListViewItem word = new ListViewItem(words);
                            uxSelectedListView.Items.Add(word);
                            word.SubItems.Add(selectedWords[words].ToString(_frequencyFormat));

                        }
                        
                    }
                }

            }
            uxSelectedListView.EndUpdate();
        }

        private void uxAllFilesListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            reverseSort(e, uxAllFilesListView, _allFilesHeadings);
            //ListViewColumnSorter temp = new ListViewColumnSorter();
            //temp.SortColumn = e.Column;
            //if (uxAllFilesListView.Columns[e.Column].Text.Contains(_headingSuffixes[1]))
            //{
            //    temp.Order = SortOrder.Descending;
            //    uxAllFilesListView.ListViewItemSorter = temp;
            //    uxAllFilesListView.Columns[e.Column].Text = _allFilesHeadings[e.Column] + _headingSuffixes[2];
            //}
            //else
            //{
            //    temp.Order = SortOrder.Ascending;
            //    uxAllFilesListView.Columns[e.Column].Text = _allFilesHeadings[e.Column] + _headingSuffixes[1];
            //}
            
           

        }

        private void uxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (uxTextBox.Text != "")
            {
                Dictionary<string, float> selected = _frequencyTabels[uxTextBox.Text];
                foreach (ListViewItem fn in uxAllFilesListView.Items)
                {
                    Dictionary<string, float> temp = _frequencyTabels[fn.Text];
                    float diff = Analyzer.Difference(selected, temp, (int)uxNumericUpDown.Value);
                    fn.SubItems[_differenceColumn].Text = diff.ToString(_differenceFormat);
                    uxAllFilesListView.Columns[_differenceColumn].Text = _allFilesHeadings[2] + _headingSuffixes[0];
                }
            }
        }

        private void uxThreshold_ValueChanged(object sender, EventArgs e)
        {
            uxSelectedListView.Items.Clear();
            Dictionary<string, float> selectedWords = _frequencyTabels[uxTextBox.Text];
            foreach (string words in selectedWords.Keys)
            {
                if ((decimal)selectedWords[words] >= uxThreshold.Value)
                {
                    
                    ListViewItem word = new ListViewItem(words);
                    uxSelectedListView.Items.Add(word);
                    word.SubItems.Add(selectedWords[words].ToString(_frequencyFormat));
                }

            }
        }
    }
}
