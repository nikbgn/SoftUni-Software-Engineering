using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (char a = 'a'; a < 'a'+input; a++)
            {
                for (char b = 'a'; b < 'a'+input; b++)
                {
                    for (char c = 'a'; c < 'a'+input; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
