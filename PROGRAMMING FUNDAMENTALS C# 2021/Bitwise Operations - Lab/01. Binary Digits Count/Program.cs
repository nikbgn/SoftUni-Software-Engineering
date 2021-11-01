using System;
using System.Linq;

namespace _01._Binary_Digits_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            char binaryDigit = char.Parse(Console.ReadLine());
            string numBinaryRepresentation = Convert.ToString(num, 2);
            Console.WriteLine(numBinaryRepresentation.Where(digit => digit == binaryDigit).ToArray().Length);
        }
    }


    //You are given a positive integer number and one binary digit B (0 or 1). Your task is to write a program that finds the number of binary digits(B) in given integer.
}
