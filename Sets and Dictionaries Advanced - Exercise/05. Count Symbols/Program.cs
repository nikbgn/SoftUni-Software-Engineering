using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<char, int> charsCount = new SortedDictionary<char, int>();
            string text = Console.ReadLine();
            foreach (var character in text)
            {
                if (!charsCount.ContainsKey(character))
                {
                    charsCount.Add(character, 0);
                }
                charsCount[character]++;
            }
            foreach (var item in charsCount)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
