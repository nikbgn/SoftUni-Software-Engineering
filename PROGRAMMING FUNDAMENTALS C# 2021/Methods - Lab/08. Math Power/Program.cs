using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(raiseNumToPower(number,power));
        }


        static double raiseNumToPower(double a, int b)
        {
            double result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }
    }
}
