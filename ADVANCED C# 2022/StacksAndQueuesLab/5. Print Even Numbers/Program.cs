using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueOfInts = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            List<int> result = new List<int>();
            while (queueOfInts.Count > 0)
            {
                int currNum = queueOfInts.Dequeue();
                if (currNum % 2 == 0) result.Add(currNum);
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
