using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                switch (command[0].ToLower())
                {
                    case "add":
                        int n1 = int.Parse(command[1]);
                        int n2 = int.Parse(command[2]);
                        stack.Push(n1);
                        stack.Push(n2);
                        break;
                    case "remove":
                        int numOfItemsToRemove = int.Parse(command[1]);
                        if (stack.Count >= numOfItemsToRemove)
                        {
                            for (int i = 0; i < numOfItemsToRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                    case "end":
                        int sum = 0;
                        while (stack.Count > 0)
                        {
                            sum += stack.Pop();
                        }
                        Console.WriteLine($"Sum: {sum}");
                        return;
                    default:
                        break;
                }
            }

        }
    }
}
