using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> expression = new Stack<string>(Console.ReadLine().Split().Reverse());
            int result = int.Parse(expression.Pop());
            while (expression.Count > 0)
            {
                string operation = expression.Pop();
                if (operation == "+") result += int.Parse(expression.Pop());
                else result -= int.Parse(expression.Pop());
            }
            Console.WriteLine(result);

        }
    }
}
