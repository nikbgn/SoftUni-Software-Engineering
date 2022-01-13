using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string userInput = Console.ReadLine();
            foreach (var character in userInput)
            {
                stack.Push(character);
            }
            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
