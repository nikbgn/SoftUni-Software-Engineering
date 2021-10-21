using System;

namespace _01.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double course = 1.79549;
            double bgn = usd * course;
            Console.WriteLine(bgn);
        }
    }
}
