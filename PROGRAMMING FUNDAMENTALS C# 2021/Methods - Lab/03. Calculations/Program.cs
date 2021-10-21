using System;

namespace _03._Calculations
{
    class Program
    {

        static void Calculate(string Operator,int a,int b)
        {
            switch (Operator)
            {
                case "add":
                    Console.WriteLine(a+b);
                    break;
                case "substract":
                    Console.WriteLine(a - b);
                    break;
                case "multiply":
                    Console.WriteLine(a * b);
                    break;
                case "divide":
                    if (a == 0 || b == 0) { Console.WriteLine("Cannot divide by zero!"); }
                    else { Console.WriteLine(a / b); }
                    
                    break;
            }

        }

        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Calculate(operation, num1, num2);
        }
    }
}
