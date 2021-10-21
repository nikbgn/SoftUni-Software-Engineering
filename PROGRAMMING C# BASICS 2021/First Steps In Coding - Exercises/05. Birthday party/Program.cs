using System;

namespace _05._Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double hallPrice = double.Parse(Console.ReadLine());
            double cakePrice = hallPrice * 0.2;
            double drinksPrice = cakePrice - 0.45 * cakePrice;
            double animator = hallPrice/3;
            double budgedRequired = hallPrice + cakePrice + drinksPrice + animator;
            Console.WriteLine(budgedRequired);

        }
    }
}
