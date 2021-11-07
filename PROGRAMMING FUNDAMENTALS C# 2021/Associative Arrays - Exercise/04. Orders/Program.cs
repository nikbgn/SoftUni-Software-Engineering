using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, List<double>>(); //Item, Price & Qty

            string[] command = Console.ReadLine().Split();

            while (command[0] != "buy")
            {
                string currentItem = command[0];
                double currentItemPrice = double.Parse(command[1]);
                double currentItemQty = double.Parse(command[2]);

                if (!products.ContainsKey(currentItem))
                {
                    products.Add(currentItem, new List<double>() { currentItemPrice, currentItemQty });
                }
                else
                {
                    if (currentItemPrice != products[currentItem][0])
                    {
                        products[currentItem][0] = currentItemPrice;
                    }
                    products[currentItem][1] += currentItemQty;
                }

                command = Console.ReadLine().Split();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }

        }
    }
}
