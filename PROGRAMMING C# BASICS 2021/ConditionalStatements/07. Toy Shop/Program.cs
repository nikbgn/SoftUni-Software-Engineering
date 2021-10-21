using System;

namespace _07._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prices:
            double puzzle = 2.60;
            double talkingDoll = 3;
            double teddyBear = 4.10;
            double minion = 8.20;
            double toyTruck = 2;


            //Inputs
            double travelPrice = double.Parse(Console.ReadLine());

            int puzzleCount = int.Parse(Console.ReadLine());

            int talkingDollCount = int.Parse(Console.ReadLine());

            int teddyBearCount = int.Parse(Console.ReadLine());

            int minionCount = int.Parse(Console.ReadLine());

            int toyTruckCount = int.Parse(Console.ReadLine());

            //Calculations
            int toyCount = puzzleCount + talkingDollCount + teddyBearCount + minionCount + toyTruckCount;

            double puzzlePrice = puzzleCount * puzzle;

            double talkingDollPrice = talkingDollCount * talkingDoll;

            double teddyBearPrice = teddyBearCount * teddyBear;

            double minionPrice = minionCount * minion;

            double toyTruckPrice = toyTruckCount * toyTruck;

            double finalPrice = puzzlePrice + talkingDollPrice + teddyBearPrice + minionPrice + toyTruckPrice;

            if (toyCount >= 50)
            {
                finalPrice = finalPrice - finalPrice * 0.25;

            }

            finalPrice = finalPrice - finalPrice * 0.1;

            if (finalPrice >= travelPrice)
            {
                Console.WriteLine($"Yes! {finalPrice-travelPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {travelPrice-finalPrice:F2} lv needed.");
            }

            
        }
    }
}
