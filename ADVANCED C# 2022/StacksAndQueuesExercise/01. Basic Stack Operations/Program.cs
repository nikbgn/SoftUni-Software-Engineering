using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < initialInput[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(initialInput[2])) Console.WriteLine("true");
            else Console.WriteLine(smallestElementInStack(stack)); ;
            
        }

        private static int smallestElementInStack(Stack<int> stack)
        {
            int smallestNum = int.MaxValue;
            if (stack.Count == 0) return 0;
            while (stack.Count > 0)
            {
                int currNum = stack.Pop();
                if (currNum < smallestNum) smallestNum = currNum;
            }
            return smallestNum;
        }
    }
}
