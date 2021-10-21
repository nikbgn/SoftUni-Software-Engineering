using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Console.WriteLine(takeMiddleChars(word));
        }

        static string takeMiddleChars(string s)
        {
            string result = string.Empty;
            if (s.Length % 2 == 0) { result = s[s.Length / 2 - 1] + s[s.Length / 2].ToString(); } // In case the string has an even num of chars, we must take two middle chars.
            else { result = s[s.Length / 2].ToString(); } // In case the string has an odd num of chars, we just take the middle one.
            return result;
        }
    }
}
