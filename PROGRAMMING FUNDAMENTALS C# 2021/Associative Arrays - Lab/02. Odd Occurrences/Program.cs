using System;
using System.Collections.Generic;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsDict.ContainsKey(word))
                {
                    wordsDict.Add(word.ToLower(), 1);
                }
                else
                {
                    wordsDict[word]++;
                }
            }

            foreach (var countOfWord in wordsDict)
            {
                if(countOfWord.Value % 2 != 0)
                {
                    Console.Write(countOfWord.Key + " ");
                }
            }
        }
    }
}
