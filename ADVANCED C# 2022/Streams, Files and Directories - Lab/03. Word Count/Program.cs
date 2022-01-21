using System;
using System.Collections.Generic;
using System.IO;

namespace WordCount
{
    public class WordCount
    {

        static void Main()
        {
            string wordsFilePath = @"..\..\..\words.txt";
            string textFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";
            CalculateWordCounts(wordsFilePath, textFilePath, outputFilePath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            var reader = new StreamReader(wordsFilePath);
            var writer = new StreamWriter(outputFilePath);
            using (reader)
            {
                var sentence = reader.ReadLine();
                while (sentence != null)
                {
                    string[] sentenceWords = sentence.Split(new char[] { ' ', '.', '!', ',', ';', '-', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in sentenceWords)
                    {
                        if (!wordCount.ContainsKey(item.ToLower()))
                        {
                            wordCount.Add(item.ToLower(), 0);
                        }
                    }

                    sentence = reader.ReadLine();
                }


            }
            reader = new StreamReader(textFilePath);
            using (reader)
            {

                var currSentence = reader.ReadLine();
                while (currSentence != null)
                {
                    string[] currSentenceWords = currSentence.Split(new char[] { ' ', '.', '!', ',', ';', '-', '?', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var item in currSentenceWords)
                    {
                        if (wordCount.ContainsKey(item.ToLower()))
                        {
                            wordCount[item.ToLower()]++;
                        }
                    }

                    currSentence = reader.ReadLine();
                }



            }
            using (writer)
            {
                foreach (var item in wordCount)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }


            }


        }
    }

}