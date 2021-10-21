using System;

namespace _02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine());
            string weekDay = Console.ReadLine();

            double pricePerLiterFuel = 2.10;
            double priceForHelper = 100;
            double payFuel = fuelNeeded * pricePerLiterFuel;
            switch (weekDay)
            {
                case "Sunday":

                    double discount = (priceForHelper + payFuel) - (priceForHelper + payFuel) * 0.2;
                    double moneyLeft = budget - discount;
                    if (budget >= moneyLeft && moneyLeft >= 0) { Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv."); }
                    else { Console.WriteLine($"Not enough money! Money needed: {Math.Abs(moneyLeft):f2} lv."); }
                    break;
                case "Saturday":
                    double discountSaturday = (priceForHelper + payFuel) - (priceForHelper + payFuel) * 0.1;
                    double moneyLeftSat = budget - discountSaturday;
                    if (budget >= moneyLeftSat && moneyLeftSat >= 0) { Console.WriteLine($"Safari time! Money left: {moneyLeftSat:f2} lv."); }
                    else { Console.WriteLine($"Not enough money! Money needed: {Math.Abs(moneyLeftSat):f2} lv."); }
                    break;
                default:
                    break;
            }
        }
    }
}
