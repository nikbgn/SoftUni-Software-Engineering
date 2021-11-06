using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            var synonymsDict = new Dictionary<string, List<string>>();
            int countOfWords = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfWords; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (!synonymsDict.ContainsKey(word))
                {
                    synonymsDict.Add(word, new List<string>());
                }
                synonymsDict[word].Add(synonym);
            }

            foreach (var word in synonymsDict)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ",word.Value)}");
            }
        }
    }
}
