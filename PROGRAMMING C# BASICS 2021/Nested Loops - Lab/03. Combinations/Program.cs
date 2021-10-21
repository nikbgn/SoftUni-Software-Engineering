using System;

namespace _03._Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int magicNumber = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int firstNumber = 0; firstNumber <= magicNumber; firstNumber++)
            {
                for (int secondNumber = 0; secondNumber <= magicNumber; secondNumber++)
                {
                    for (int thirdNumber = 0; thirdNumber <= magicNumber; thirdNumber++)
                    {
                        if (firstNumber+secondNumber+thirdNumber == magicNumber)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);
        }
    }
}
