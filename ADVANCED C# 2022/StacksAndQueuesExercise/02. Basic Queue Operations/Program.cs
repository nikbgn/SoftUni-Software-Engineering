using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < initialInput[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(initialInput[2])) Console.WriteLine("true");
            else Console.WriteLine(smallestElementInQueue(queue)); 

        }

        private static int smallestElementInQueue(Queue<int> queue)
        {
            int smallestNum = int.MaxValue;
            if (queue.Count == 0) return 0;
            while (queue.Count > 0)
            {
                int currNum = queue.Dequeue();
                if (currNum < smallestNum) smallestNum = currNum;
            }
            return smallestNum;
        }
    }
}

