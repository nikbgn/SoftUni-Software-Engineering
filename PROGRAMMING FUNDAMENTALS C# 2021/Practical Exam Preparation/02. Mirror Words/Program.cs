using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"(\#|\@)(?<word1>[A-Za-z]{3,})\1\1(?<word2>[A-Za-z]{3,})\1";
            MatchCollection matches = Regex.Matches(input, regex);
            List<string> mirrorWords = new List<string>();
            StringBuilder output = new StringBuilder();
            int mirrorWordsCount = 0;
            
            foreach (Match item in matches)
            {
                if(item.Groups["word1"].Value == reverseString(item.Groups["word2"].Value))
                {
                    output.Append($"{item.Groups["word1"].Value} <=> {item.Groups["word2"].Value}, ");
                    mirrorWordsCount++;
                }
            }

            if(mirrorWordsCount > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!\nThe mirror words are:");
                output.Remove(output.Length - 2, 2);
                Console.WriteLine(output);
            }
            else if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!\nNo mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!\nNo mirror words!");
            }


            
        }

        private static string reverseString(string str)
        {
            string reversedStr = string.Empty;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }
            return reversedStr;
        }
    }
}
