using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{getNumberFactorial(n1) / getNumberFactorial(n2):f2}");
        }


        //Recrusive function
        static double getNumberFactorial(double number)
        {
            if (number == 0)
            {
                return 1;
            }

            return number * getNumberFactorial(number - 1);
        }
    }
}
