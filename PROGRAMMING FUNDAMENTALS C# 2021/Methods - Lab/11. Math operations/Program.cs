using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            switch (operation)
            {
                case '*':
                    Console.WriteLine(multiply(num1, num2)); 
                    break;
                case '/':
                    Console.WriteLine(divide(num1, num2));
                    break;
                case '+':
                    Console.WriteLine(add(num1, num2));
                    break;
                case '-':
                    Console.WriteLine(subtract(num1, num2));
                    break;
                default:
                    break;
            }

        }

        private static double subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double divide(double num1, double num2)
        {
            //I don't check for possible divisionByZero, because I am absolutely certain that im not going to get it as an input!
            
            return num1 / num2;
        }

        private static double multiply(double num1, double num2)
        {
            return num1 * num2;
        }
    }
}
