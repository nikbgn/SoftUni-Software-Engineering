using System;

namespace _03._Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

