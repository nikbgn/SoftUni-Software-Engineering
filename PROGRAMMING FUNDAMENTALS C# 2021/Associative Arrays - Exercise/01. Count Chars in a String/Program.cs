using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            Dictionary<char, int> countOfLetters = new Dictionary<char, int>();
            foreach (char letter in word)
            {
                if (letter != ' ')
                {
                    if (countOfLetters.ContainsKey(letter)) { countOfLetters[letter]++; }
                    else { countOfLetters.Add(letter, 1); }
                }
            }

            foreach (var item in countOfLetters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
