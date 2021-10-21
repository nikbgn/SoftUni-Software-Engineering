using System;

namespace _10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                int numbersToRead = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += numbersToRead;
                }
                else
                {
                    oddSum += numbersToRead;
                }

            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum-oddSum)}");
            }
        }
    }
}
