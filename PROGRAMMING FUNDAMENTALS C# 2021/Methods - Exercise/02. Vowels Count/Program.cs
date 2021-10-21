using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void vowels(string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u' || s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U') { count += 1; }
            }

            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            vowels(s);
        }
    }
}
