using System;

namespace _04._Fishing_Boat

{
    class Program
    {
        static void Main(string[] args)
        {
            //1. наем на кораба (зависи от сезона) - OK
            //2. отстъпка (зависи от броя на хората) - OK
            //3. доп. остъпка
            //4. проверка дали бюджетът е достатъчен

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int countFishers = int.Parse(Console.ReadLine());

            //Цената за наем на кораба през пролетта е  3000 лв.
            //Цената за наем на кораба през лятото и есента е  4200 лв.
            //Цената за наем на кораба през зимата е  2600 лв.
            double rent = 0;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                rent = 4200;
            }
            else if (season == "Winter")
            {
                rent = 2600;
            }

            //•   Ако групата е до 6 човека включително  –  отстъпка от 10%.
            //•   Ако групата е от 7 до 11 човека включително  –  отстъпка от 15 %.
            //•   Ако групата е от 12 нагоре  –  отстъпка от 25 %.

            if (countFishers <= 6)
            {
                rent = rent - 0.10 * rent; // 0.9 * rent
                //rent = rent * 0.9; -> rent *= 0.9;
            }
            else if (countFishers >= 7 && countFishers <= 11)
            {
                rent = rent - 0.15 * rent; //0.85 * rent
            }
            else if (countFishers >= 12)
            {
                rent = rent - 0.25 * rent; //0.75 * rent
            }


            //5% -> четен брой (fishersCount % 2 == 0) и сезонът да е различен от есен (season != "Autumn")
            if (countFishers % 2 == 0 && season != "Autumn")
            {
                rent = rent - 0.05 * rent; //0.95 * rent
            }

            //проверка дали бюджетът е достатъчен
            if (budget >= rent)
            {
                double leftMoney = budget - rent;
                Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
            }
            else //budget < rent
            {
                double needMoney = rent - budget;
                Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
            }

        }
    }
}