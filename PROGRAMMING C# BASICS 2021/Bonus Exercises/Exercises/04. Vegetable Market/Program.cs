using System;

namespace _04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetableKgPrice = double.Parse(Console.ReadLine());
            double fruitKgPrice = double.Parse(Console.ReadLine());
            int vegetableKg = int.Parse(Console.ReadLine());
            int fruitKg = int.Parse(Console.ReadLine());
            double BgnToEuro = 1.94;

            double vegetableProfit = vegetableKg * vegetableKgPrice;
            double fruitProfit = fruitKgPrice * fruitKg;

            double test = vegetableProfit + fruitProfit;


            double finalProfit = (vegetableProfit+fruitProfit)/BgnToEuro;

            Console.WriteLine($"{finalProfit:F2}");
        }
    }
}
