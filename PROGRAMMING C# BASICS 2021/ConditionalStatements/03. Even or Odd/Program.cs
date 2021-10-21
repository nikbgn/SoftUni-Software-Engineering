using System;

namespace _03._Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num%2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
