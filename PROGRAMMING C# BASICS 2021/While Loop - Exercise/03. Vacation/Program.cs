using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            int spendingCounter = 0;
            int daysCounter = 0;

            while (currentMoney < moneyNeeded && spendingCounter < 5)
            {
                string command = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                daysCounter++;

                if (command == "save") { currentMoney += money; spendingCounter = 0; }
                else if (command == "spend")
                {
                    if (currentMoney - money <= 0)
                    {
                        currentMoney = 0;
                        spendingCounter++;
                    }
                    else
                    {
                        currentMoney -= money;
                        spendingCounter++;
                    }
                }

            }



            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            if (currentMoney >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
