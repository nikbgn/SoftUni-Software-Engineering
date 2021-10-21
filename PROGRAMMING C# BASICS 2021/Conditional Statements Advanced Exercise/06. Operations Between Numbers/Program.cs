using System;

namespace _06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    int sum = num1 + num2;
                    
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} + {num2} = {sum} - odd");
                    }
                    
                    break;
                case "-":
                    int diff = num1 - num2;

                    if (diff % 2 == 0)
                    {
                        Console.WriteLine($"{num1} - {num2} = {diff} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} - {num2} = {diff} - odd");
                    }
                    break;

                case "*":
                    int res = num1 * num2;

                    if (res % 2 == 0)
                    {
                        Console.WriteLine($"{num1} * {num2} = {res} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{num1} * {num2} = {res} - odd");
                    }
                    break;

                case "/":

                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        double div = num1 * 1.0 / num2;
                        Console.WriteLine($"{num1} / {num2} = {div:F2}");
                    }

                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {num1} by zero");
                    }
                    else
                    {
                        int mod = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {mod}");
                    }
                    break;
            }

        }
    }
}
