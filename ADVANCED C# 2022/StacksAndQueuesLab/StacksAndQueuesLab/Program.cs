using System;
using System.Collections.Generic;

namespace StacksAndQueuesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(2);
            stack.Push(1000);
            Console.WriteLine(stack.Peek());
        }
    }
}
