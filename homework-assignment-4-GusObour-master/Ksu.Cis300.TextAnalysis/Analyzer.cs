using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Ksu.Cis300.TextAnalysis
{
    static class Analyzer
    {
        private const string _splitExpression = "[^a-z]+";
        public static Dictionary<string,Dictionary<string , float>> GetFreqTabel(string folderName)
        {
            Dictionary<string, Dictionary<string, float>> FrequencyTabel= new Dictionary<string, Dictionary<string, float>>();
            DirectoryInfo folderDirectoryInfo = new DirectoryInfo(folderName);
            FileInfo[] files = folderDirectoryInfo.GetFiles();
            foreach(FileInfo file in files)
            {
                Dictionary<string, int> wordsDic= new Dictionary<string, int>();
                Dictionary<string, float> wordsFreq = new Dictionary<string, float>();
                using (StreamReader sr = File.OpenText(file.FullName))
                {
                    string line;
                    while ( (line = sr.ReadLine()) != null)
                    {
                        line = line.ToLower();
                        string[] words = Regex.Split(line,_splitExpression);
                        foreach (string word in words)
                        {
                            if (wordsDic.ContainsKey(word))
                            {
                                wordsDic[word]++;
                            }
                            else
                            {
                                wordsDic.Add(word, 1);
                            }
                        }
                    }
                }
                foreach (KeyValuePair<String, int> pair in wordsDic)
                {
                    float freq = (float)pair.Value / wordsDic.Count;
                    wordsFreq.Add(pair.Key, freq);
                }
                FrequencyTabel.Add(file.Name, wordsFreq);
            }
            return FrequencyTabel;
        }

        public static float Difference(Dictionary<string, float> file1, Dictionary<string, float> file2, int maxNumOfWords)
        {
            float difference = 0;
            MinPriorityQueue<float, string> wordsPriorityQueue = new MinPriorityQueue<float, string>();
            foreach(string word in file1.Keys)
            {
                if(file2.ContainsKey(word))
                {
                    float min = Math.Min(file1[word], file2[word]);
                    wordsPriorityQueue.Add(min, word);
                    if(wordsPriorityQueue.Count > maxNumOfWords)
                    {
                        wordsPriorityQueue.RemoveMinimumPriority();
                    }
                }
            }
            if(wordsPriorityQueue.Count==0)
            {
                return float.PositiveInfinity;
            }
            else
            {
                while(wordsPriorityQueue.Count>0)
                {
                    string word = wordsPriorityQueue.RemoveMinimumPriority();
                    difference = (file1[word] - file2[word]) * (file1[word] - file2[word]);
                }
                difference = (float)Math.Sqrt(difference);
            }
            return difference;
        }
    }
}
