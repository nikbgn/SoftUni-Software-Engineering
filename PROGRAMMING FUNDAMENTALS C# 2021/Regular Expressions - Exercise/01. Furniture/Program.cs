using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneySpentTotal = 0;
            List<string> boughtFurniture = new List<string>();
            string regex = @">>(?<item>[A-z][a-z]+|[A-z][A-Z])<<(?<price>\d+\.?\d{2})!(?<qty>\d+)$";
            string input = Console.ReadLine();
            while (input != "Purchase")
            {
                Match item = Regex.Match(input, regex, RegexOptions.IgnoreCase);
                if (item.Success)
                {
                    boughtFurniture.Add(item.Groups["item"].Value);

                    moneySpentTotal += double.Parse(item.Groups["price"].Value) * double.Parse(item.Groups["qty"].Value);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (boughtFurniture.Count > 0)
            {
                Console.WriteLine(string.Join("\n", boughtFurniture));
            }
            Console.WriteLine($"Total money spend: {moneySpentTotal:f2}");


        }
    }
}
