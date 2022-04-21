namespace Ksu.Cis300.TextAnalysis
{
    partial class uxTextAnalyzer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uxTextAnalyzer));
            this.uxToolStrip = new System.Windows.Forms.ToolStrip();
            this.uxOpenfile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uxSelectedfile = new System.Windows.Forms.ToolStripLabel();
            this.uxTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.uxTabControl = new System.Windows.Forms.TabControl();
            this.uxAllFiles = new System.Windows.Forms.TabPage();
            this.uxAllFilesListView = new System.Windows.Forms.ListView();
            this.uxFileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxVocabulary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxDifference = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uxLabel = new System.Windows.Forms.Label();
            this.uxSelected = new System.Windows.Forms.TabPage();
            this.uxSelectedListView = new System.Windows.Forms.ListView();
            this.uxWord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.uxThreshold = new System.Windows.Forms.NumericUpDown();
            this.uxThresholdLabel = new System.Windows.Forms.Label();
            this.uxBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.uxToolStrip.SuspendLayout();
            this.uxTabControl.SuspendLayout();
            this.uxAllFiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).BeginInit();
            this.uxSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // uxToolStrip
            // 
            this.uxToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpenfile,
            this.toolStripSeparator1,
            this.uxSelectedfile,
            this.uxTextBox});
            this.uxToolStrip.Location = new System.Drawing.Point(0, 0);
            this.uxToolStrip.Name = "uxToolStrip";
            this.uxToolStrip.Size = new System.Drawing.Size(863, 26);
            this.uxToolStrip.TabIndex = 0;
            this.uxToolStrip.Text = "toolStrip1";
            // 
            // uxOpenfile
            // 
            this.uxOpenfile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.uxOpenfile.Image = ((System.Drawing.Image)(resources.GetObject("uxOpenfile.Image")));
            this.uxOpenfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.uxOpenfile.Name = "uxOpenfile";
            this.uxOpenfile.Size = new System.Drawing.Size(40, 23);
            this.uxOpenfile.Text = "Open";
            this.uxOpenfile.Click += new System.EventHandler(this.uxOpenfile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // uxSelectedfile
            // 
            this.uxSelectedfile.Name = "uxSelectedfile";
            this.uxSelectedfile.Size = new System.Drawing.Size(78, 23);
            this.uxSelectedfile.Text = "Selected File: ";
            // 
            // uxTextBox
            // 
            this.uxTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxTextBox.Name = "uxTextBox";
            this.uxTextBox.ReadOnly = true;
            this.uxTextBox.Size = new System.Drawing.Size(350, 26);
            // 
            // uxTabControl
            // 
            this.uxTabControl.Controls.Add(this.uxAllFiles);
            this.uxTabControl.Controls.Add(this.uxSelected);
            this.uxTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uxTabControl.Location = new System.Drawing.Point(0, 26);
            this.uxTabControl.Name = "uxTabControl";
            this.uxTabControl.SelectedIndex = 0;
            this.uxTabControl.Size = new System.Drawing.Size(863, 597);
            this.uxTabControl.TabIndex = 1;
            // 
            // uxAllFiles
            // 
            this.uxAllFiles.Controls.Add(this.uxAllFilesListView);
            this.uxAllFiles.Controls.Add(this.uxNumericUpDown);
            this.uxAllFiles.Controls.Add(this.uxLabel);
            this.uxAllFiles.Location = new System.Drawing.Point(4, 27);
            this.uxAllFiles.Name = "uxAllFiles";
            this.uxAllFiles.Padding = new System.Windows.Forms.Padding(3);
            this.uxAllFiles.Size = new System.Drawing.Size(855, 566);
            this.uxAllFiles.TabIndex = 0;
            this.uxAllFiles.Text = "All Files: ";
            this.uxAllFiles.UseVisualStyleBackColor = true;
            // 
            // uxAllFilesListView
            // 
            this.uxAllFilesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxAllFilesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxFileName,
            this.uxVocabulary,
            this.uxDifference});
            this.uxAllFilesListView.GridLines = true;
            this.uxAllFilesListView.HideSelection = false;
            this.uxAllFilesListView.Location = new System.Drawing.Point(3, 31);
            this.uxAllFilesListView.MultiSelect = false;
            this.uxAllFilesListView.Name = "uxAllFilesListView";
            this.uxAllFilesListView.Size = new System.Drawing.Size(844, 529);
            this.uxAllFilesListView.TabIndex = 2;
            this.uxAllFilesListView.UseCompatibleStateImageBehavior = false;
            this.uxAllFilesListView.View = System.Windows.Forms.View.Details;
            this.uxAllFilesListView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.uxAllFilesListView_ColumnClick);
            this.uxAllFilesListView.SelectedIndexChanged += new System.EventHandler(this.uxAllFilesListView_SelectedIndexChanged);
            // 
            // uxFileName
            // 
            this.uxFileName.Text = "File Name";
            this.uxFileName.Width = 250;
            // 
            // uxVocabulary
            // 
            this.uxVocabulary.Text = "Vocabulary";
            this.uxVocabulary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxVocabulary.Width = 150;
            // 
            // uxDifference
            // 
            this.uxDifference.Text = "Difference";
            this.uxDifference.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxDifference.Width = 150;
            // 
            // uxNumericUpDown
            // 
            this.uxNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.uxNumericUpDown.Location = new System.Drawing.Point(187, 4);
            this.uxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxNumericUpDown.Name = "uxNumericUpDown";
            this.uxNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.uxNumericUpDown.TabIndex = 1;
            this.uxNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxNumericUpDown.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.uxNumericUpDown.ValueChanged += new System.EventHandler(this.uxNumericUpDown_ValueChanged);
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(4, 7);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(179, 18);
            this.uxLabel.TabIndex = 0;
            this.uxLabel.Text = "Number of Words Used: ";
            // 
            // uxSelected
            // 
            this.uxSelected.Controls.Add(this.uxSelectedListView);
            this.uxSelected.Controls.Add(this.uxThreshold);
            this.uxSelected.Controls.Add(this.uxThresholdLabel);
            this.uxSelected.Location = new System.Drawing.Point(4, 27);
            this.uxSelected.Name = "uxSelected";
            this.uxSelected.Padding = new System.Windows.Forms.Padding(3);
            this.uxSelected.Size = new System.Drawing.Size(855, 566);
            this.uxSelected.TabIndex = 1;
            this.uxSelected.Text = "Selected";
            this.uxSelected.UseVisualStyleBackColor = true;
            // 
            // uxSelectedListView
            // 
            this.uxSelectedListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uxSelectedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.uxWord,
            this.uxFrequency});
            this.uxSelectedListView.GridLines = true;
            this.uxSelectedListView.HideSelection = false;
            this.uxSelectedListView.Location = new System.Drawing.Point(7, 35);
            this.uxSelectedListView.MultiSelect = false;
            this.uxSelectedListView.Name = "uxSelectedListView";
            this.uxSelectedListView.Size = new System.Drawing.Size(842, 513);
            this.uxSelectedListView.TabIndex = 4;
            this.uxSelectedListView.UseCompatibleStateImageBehavior = false;
            this.uxSelectedListView.View = System.Windows.Forms.View.Details;
            // 
            // uxWord
            // 
            this.uxWord.Text = "Word";
            this.uxWord.Width = 250;
            // 
            // uxFrequency
            // 
            this.uxFrequency.Text = "Frequency";
            this.uxFrequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxFrequency.Width = 150;
            // 
            // uxThreshold
            // 
            this.uxThreshold.DecimalPlaces = 5;
            this.uxThreshold.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.uxThreshold.Location = new System.Drawing.Point(98, 3);
            this.uxThreshold.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxThreshold.Name = "uxThreshold";
            this.uxThreshold.Size = new System.Drawing.Size(120, 26);
            this.uxThreshold.TabIndex = 3;
            this.uxThreshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.uxThreshold.Value = new decimal(new int[] {
            100,
            0,
            0,
            327680});
            this.uxThreshold.ValueChanged += new System.EventHandler(this.uxThreshold_ValueChanged);
            // 
            // uxThresholdLabel
            // 
            this.uxThresholdLabel.AutoSize = true;
            this.uxThresholdLabel.Location = new System.Drawing.Point(8, 7);
            this.uxThresholdLabel.Name = "uxThresholdLabel";
            this.uxThresholdLabel.Size = new System.Drawing.Size(84, 18);
            this.uxThresholdLabel.TabIndex = 2;
            this.uxThresholdLabel.Text = "Threshold: ";
            // 
            // uxTextAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 623);
            this.Controls.Add(this.uxTabControl);
            this.Controls.Add(this.uxToolStrip);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uxTextAnalyzer";
            this.Text = "Text Analyzer";
            this.uxToolStrip.ResumeLayout(false);
            this.uxToolStrip.PerformLayout();
            this.uxTabControl.ResumeLayout(false);
            this.uxAllFiles.ResumeLayout(false);
            this.uxAllFiles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxNumericUpDown)).EndInit();
            this.uxSelected.ResumeLayout(false);
            this.uxSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uxThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip uxToolStrip;
        private System.Windows.Forms.ToolStripButton uxOpenfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel uxSelectedfile;
        private System.Windows.Forms.ToolStripTextBox uxTextBox;
        private System.Windows.Forms.TabControl uxTabControl;
        private System.Windows.Forms.TabPage uxAllFiles;
        private System.Windows.Forms.TabPage uxSelected;
        private System.Windows.Forms.ListView uxAllFilesListView;
        private System.Windows.Forms.ColumnHeader uxFileName;
        private System.Windows.Forms.ColumnHeader uxVocabulary;
        private System.Windows.Forms.ColumnHeader uxDifference;
        private System.Windows.Forms.NumericUpDown uxNumericUpDown;
        private System.Windows.Forms.Label uxLabel;
        private System.Windows.Forms.NumericUpDown uxThreshold;
        private System.Windows.Forms.Label uxThresholdLabel;
        private System.Windows.Forms.ListView uxSelectedListView;
        private System.Windows.Forms.ColumnHeader uxWord;
        private System.Windows.Forms.ColumnHeader uxFrequency;
        private System.Windows.Forms.FolderBrowserDialog uxBrowserDialog;
    }
}

