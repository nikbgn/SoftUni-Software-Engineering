using System;

namespace _06.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int countStatists = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());

            double decorPrice = 0.1 * movieBudget;
            double clothesPrice = countStatists * pricePerStatist;

            if (countStatists > 150)
            {
                clothesPrice = clothesPrice - 0.10 * clothesPrice;
            }

            double expenses = decorPrice + clothesPrice;

            if (movieBudget >= expenses)
            {
                Console.WriteLine("Action!");
                double moneyLeft = movieBudget - expenses;
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }

            else
            {
                Console.WriteLine("Not enough money!");
                double needMoney = expenses - movieBudget;
                Console.WriteLine($"Wingard needs {needMoney:F2} leva more.");
            }
        }
    }
}
