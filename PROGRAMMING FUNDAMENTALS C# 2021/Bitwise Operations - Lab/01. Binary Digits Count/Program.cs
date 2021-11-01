using System;
using System.Linq;

namespace _01._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());
            numToBase2Solution(num, binaryDigit);
        }



        public static void numToBase2Solution(int number, int binaryDigit)
        {
            int countOfBinDigit = 0;
            while (number != 0)
            {
                int leftOver = number % 2;
                if (leftOver == binaryDigit) { countOfBinDigit++; }
                number /= 2;
            }

            Console.WriteLine(countOfBinDigit);
        }

    }


    //You are given a positive integer number and one binary digit B (0 or 1). Your task is to write a program that finds the number of binary digits(B) in given integer.
}
