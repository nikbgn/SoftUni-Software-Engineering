using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.MinValue;
            string input = Console.ReadLine();
            while (input != "Stop")
            {
                int number = int.Parse(input);
                if (number > maxNumber)
                {
                    maxNumber = number;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(maxNumber);
            
        }
    }
}
