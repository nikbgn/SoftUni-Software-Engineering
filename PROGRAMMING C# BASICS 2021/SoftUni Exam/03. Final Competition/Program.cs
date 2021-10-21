using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            //INPUT
            int dancersCount = int.Parse(Console.ReadLine());
            double pointsCount = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();
            double wonMoney = dancersCount * pointsCount;
            double moneyForCharity = 0;
            double moneyLeft = 0;

            if (place == "Abroad")
            {
                wonMoney += wonMoney * 0.5;
                if (season == "summer")
                {
                    wonMoney -= wonMoney * 0.10;
                    moneyForCharity = wonMoney * 0.75;
                    moneyLeft = wonMoney - moneyForCharity;

                    Console.WriteLine($"Charity - {moneyForCharity:f2}\r\nMoney per dancer - {moneyLeft/dancersCount:f2}");
                }
                else if(season == "winter")
                {
                    wonMoney -= wonMoney * 0.15;
                    moneyForCharity = wonMoney * 0.75;
                    moneyLeft = wonMoney - moneyForCharity;

                    Console.WriteLine($"Charity - {moneyForCharity:f2}\r\nMoney per dancer - {moneyLeft / dancersCount:f2}");
                }
            }

            else if (place == "Bulgaria")
            {
                if (season == "summer")
                {
                    wonMoney -= wonMoney * 0.05;
                    moneyForCharity = wonMoney * 0.75;
                    moneyLeft = wonMoney - moneyForCharity;

                    Console.WriteLine($"Charity - {moneyForCharity:f2}\r\nMoney per dancer - {moneyLeft / dancersCount:f2}");
                }
                else if (season == "winter")
                {
                    wonMoney -= wonMoney * 0.08;
                    moneyForCharity = wonMoney * 0.75;
                    moneyLeft = wonMoney - moneyForCharity;

                    Console.WriteLine($"Charity - {moneyForCharity:f2}\r\nMoney per dancer - {moneyLeft / dancersCount:f2}");
                }
            }
        }
    }
}
