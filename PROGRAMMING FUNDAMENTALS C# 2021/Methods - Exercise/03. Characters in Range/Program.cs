using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Range(char a, char b)
        {
            if (a > b)
            {
                for (int i = (char)b+1; i < a; i++)
                {
                    Console.Write((char)i + " ");
                }
            }
            else
            {
                for (int i = (char)a + 1; i < b; i++)
                {
                    Console.Write((char)i + " ");
                }
            }

        }
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            Range(start, end);
        }
    }
}
