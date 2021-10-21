using System;

namespace _04._Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= N; rows++)
            {
                for (int cows = 1; cows <= rows; cows++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
