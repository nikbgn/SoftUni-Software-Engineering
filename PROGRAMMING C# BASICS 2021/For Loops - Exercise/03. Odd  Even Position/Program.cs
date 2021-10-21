using System;

namespace _03._Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= lines; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += num;
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                }

                else if (i % 2 != 0)
                {
                    oddSum += num;
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }

                }
            }

            if (lines == 0) { Console.WriteLine($"OddSum=0.00,\nOddMin=No,\nOddMax=No,\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No"); }
            else if (lines == 1) { Console.WriteLine($"OddSum={oddSum:f2},\nOddMin={oddMin:f2},\nOddMax={oddMax:f2},\nEvenSum=0.00,\nEvenMin=No,\nEvenMax=No"); }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},\nOddMin={oddMin:f2},\nOddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},\nEvenMin={evenMin:f2},\nEvenMax={evenMax:f2}");
            }
        }
    }
}
