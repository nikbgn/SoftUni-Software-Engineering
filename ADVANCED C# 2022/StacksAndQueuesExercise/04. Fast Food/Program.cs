using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {


            int foodQTY = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            PrintBiggestOrder(orders);
            while (orders.Count > 0)
            {
                int currOrder = orders.Peek();
                if (foodQTY >= currOrder)
                {
                    foodQTY -= orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
                    return;
                }
            }

            Console.WriteLine("Orders complete");
        }

        private static void PrintBiggestOrder(Queue<int> orders)
        {
            int max = int.MinValue;
            foreach (var item in orders)
            {
                if (item > max) max = item;
            }
            Console.WriteLine(max);
        }
    }
}
