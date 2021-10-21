using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {

        static void DecideOperator(int num)
        {
            if(num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if(num == 0)
            {
                Console.WriteLine($"The number {num} is zero.");
            }
            else
            {
                Console.WriteLine($"The number {num} is positive.");
            }
        }
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            DecideOperator(input);
        }
    }
}
