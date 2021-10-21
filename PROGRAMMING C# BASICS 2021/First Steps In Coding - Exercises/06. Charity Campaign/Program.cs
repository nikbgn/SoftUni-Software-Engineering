using System;

namespace _06._Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //⦁	Броят на дните, в които тече кампанията – цяло число в интервала[0 … 365]
            //⦁	Броят на сладкарите – цяло число в интервала[0 … 1000]
            //⦁	Броят на тортите – цяло число в интервала[0… 2000]
            //⦁	Броят на гофретите – цяло число в интервала[0 … 2000]
            //⦁	Броят на палачинките – цяло число в интервала[0 … 2000]

            int daysCampagin = int.Parse(Console.ReadLine());
            int cooks = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int wafflesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            //Prices

            int cakePrice = 45;
            double wafflePrice = 5.80;
            double pancakePrice = 3.20;

            //Calcs
            int cakeMoney = cakesCount * cakePrice;
            double waffleMoney = wafflesCount * wafflePrice;
            double pancakeMoney = pancakesCount * pancakePrice;
            double moneyPerDay = (cakeMoney + waffleMoney + pancakeMoney) * cooks;
            double campaginMoney = moneyPerDay * daysCampagin;
            double finalSum = campaginMoney - campaginMoney / 8;
            Console.WriteLine(finalSum);
        }
    }
}
