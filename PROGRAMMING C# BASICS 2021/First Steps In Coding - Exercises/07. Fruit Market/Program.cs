using System;

namespace _07._Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceStrawberries = double.Parse(Console.ReadLine());
            double quantityBananas = double.Parse(Console.ReadLine());
            double quantityOranges = double.Parse(Console.ReadLine());
            double quantityRaspberries = double.Parse(Console.ReadLine());
            double quantityStrawberries = double.Parse(Console.ReadLine());

            //Ягоди

            double totalPriceStrawberries = priceStrawberries * quantityStrawberries;
            //Малини

            double priceRaspberries = (priceStrawberries / 2);
            double totalPriceRaspberries = priceRaspberries * quantityRaspberries;
            //Банани
            double priceBananas = priceRaspberries - 0.8 * priceRaspberries;
            double totalPriceBananas = priceBananas * quantityBananas;
            //Портокали
            double priceOranges = priceRaspberries - 0.4 * priceRaspberries;
            double totalPriceOranges = priceOranges * quantityOranges;

            double totalPrice = totalPriceStrawberries + totalPriceRaspberries + totalPriceOranges + totalPriceBananas;
            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}
