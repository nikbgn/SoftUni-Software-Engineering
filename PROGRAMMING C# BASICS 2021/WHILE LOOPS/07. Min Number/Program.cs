using System;

namespace _07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = int.MaxValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number < minNumber)
                {
                    minNumber = number;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(minNumber);
        }
    }
}
