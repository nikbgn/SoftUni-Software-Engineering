using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> dict = new Dictionary<string, Dictionary<string, double>>();
            string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while(command[0] != "Revision")
            {
                string shop = command[0];
                string product = command[1];
                double productPrice = double.Parse(command[2]);

                if (!dict.ContainsKey(shop))
                {
                    dict.Add(shop, new Dictionary<string, double>());
                    dict[shop].Add(product, productPrice);
                }
                else
                {
                    dict[shop].Add(product, productPrice);
                }

                command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }


            foreach (var shop in dict.OrderBy(shopName => shopName.Key))
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var item in shop.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
