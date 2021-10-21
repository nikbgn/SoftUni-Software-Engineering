using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int x = 1; x < i; x++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine(i);
            }
        }
    }
}
