using System;

namespace _05._Hair_Salon
{
    class Program
    {
        static void Main(string[] args)
        {
            int dailyTarget = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int moneyGathered = 0;
            while (command != "closed")
            {
                if (command == "haircut")
                {
                    string typeOfHaircut = Console.ReadLine();
                    switch (typeOfHaircut)
                    {
                        case "mens":
                            moneyGathered += 15;
                            break;
                        case "ladies":
                            moneyGathered += 20;
                            break;
                        case "kids":
                            moneyGathered += 10;
                            break;
                        default:
                            break;
                    }
                }
                else if (command == "color")
                {
                    string typeOfColoring = Console.ReadLine();
                    switch (typeOfColoring)
                    {
                        case "touch up":
                            moneyGathered += 20;
                            break;
                        case "full color":
                            moneyGathered += 30;
                            break;
                    }
                }

                if (moneyGathered >= dailyTarget) 
                {
                    Console.WriteLine("You have reached your target for the day!");
                    Console.WriteLine($"Earned money: {moneyGathered}lv.");
                    command = "closed";
                    break;
                }

                command = Console.ReadLine();
            }

            if (moneyGathered < dailyTarget)
            {
                Console.WriteLine($"Target not reached! You need {dailyTarget-moneyGathered}lv. more.");
                Console.WriteLine($"Earned money: {moneyGathered}lv.");
            }
        }
    }
}
