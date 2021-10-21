using System;

namespace _06._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int number = 1111; number <= 9999; number++)
            {
                int thousands = number / 1000;
                int hundreds = (number / 100) % 10;
                int tens = (number / 10) % 10;
                int units = number % 10;

                try
                {
                    if (n % thousands == 0 && n % hundreds == 0 && n % tens == 0 && n % units == 0)
                    {
                        Console.Write($"{number} ");
                    }
                }
                catch { }

            }
        }
    }
}
