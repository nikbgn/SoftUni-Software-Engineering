using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            Console.WriteLine(takeOrder(item, qty)); 
        }

        static string takeOrder(string item,int qty)
        {
            double waterPrice = 1.00;
            double coffeePrice = 1.50;
            double cokePrice = 1.40;
            double snacksPrice = 2.00;
            double res = 0.00;

            switch (item)
            {
                case "water":
                    res = waterPrice * qty;
                    break;
                case "coffee":
                    res = coffeePrice * qty;
                    break;
                case "coke":
                    res = cokePrice * qty;
                    break;
                case "snacks":
                    res = snacksPrice * qty;
                    break;
            }

            return  $"{res:f2}";
        }
    }

}