using System;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int numOfQueries = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfQueries; i++)
            {
                string[] currQuery = Console.ReadLine().Split();
                switch (int.Parse(currQuery[0]))
                {
                    case 1:
                        int elementX = int.Parse(currQuery[1]);
                        stack.Push(elementX);
                        break;
                    case 2:
                        if(stack.Count > 0) stack.Pop();
                        break;
                    case 3:
                        PrintStackBiggestNum(stack);
                        break;
                    case 4:
                        PrintStackSmallestNum(stack);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ",stack));


        }

        private static void PrintStackSmallestNum(Stack<int> stack)
        {
            if (stack.Count == 0) return;
            int min = int.MaxValue;
            foreach (var item in stack)
            {
                if (item < min) min = item;
            }
            Console.WriteLine(min);
        }

        private static void PrintStackBiggestNum(Stack<int> stack)
        {
            if (stack.Count == 0) return;
            int max = int.MinValue;
            foreach (var item in stack)
            {
                if (item > max) max = item;
            }
            Console.WriteLine(max);
        }
    }
}
