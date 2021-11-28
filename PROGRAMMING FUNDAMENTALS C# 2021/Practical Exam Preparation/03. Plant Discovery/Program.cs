using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Plant
    {
        public string plantName;
        public int rarity;
        List<double> rates = new List<double>();
        public double averageRate = 0;
        public void AddRate(double rate)
        {
            this.averageRate = 0;
            this.rates.Add(rate);
            foreach (var r in rates)
            {
                averageRate += r;
            }

            this.averageRate = averageRate / rates.Count;

        }

        public void removeRates() => rates.Clear();
    }


    class Program
    {
        static void Main(string[] args)
        {
            int numOfPlants = int.Parse(Console.ReadLine());
            Dictionary<string, Plant> plantsInfo = new Dictionary<string, Plant>();
            //Fill plants Dictionary
            for (int i = 0; i < numOfPlants; i++)
            {
                string[] input = Console.ReadLine().Split("<->");
                if (!plantsInfo.ContainsKey(input[0]))
                {
                    Plant currentPlant = new Plant();
                    currentPlant.rarity = int.Parse(input[1]);
                    plantsInfo.Add(input[0], currentPlant);
                }
                else
                {
                    plantsInfo[input[0]].rarity = int.Parse(input[1]);
                }
            }

            
            //Recieve commands
            string[] command = Console.ReadLine().Split();
            while(command[0] != "Exhibition")
            {
                string currentCommand = command[0];
                switch (currentCommand)
                {

                    case "Rate:":
                        string plantToRate = command[1];
                        string plantRatingPoints = command[3];
                        if (plantsInfo.ContainsKey(plantToRate))
                        {
                            plantsInfo[plantToRate].AddRate(double.Parse(plantRatingPoints));
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Update:":
                        string plantToUpdate = command[1];
                        int newRarity = int.Parse(command[3]);
                        if (plantsInfo.ContainsKey(plantToUpdate))
                        {
                            plantsInfo[plantToUpdate].rarity = newRarity;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "Reset:":
                        string plantToReset = command[1];
                        if (plantsInfo.ContainsKey(plantToReset))
                        {
                            plantsInfo[plantToReset].removeRates();
                            plantsInfo[plantToReset].averageRate = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plantsInfo.OrderByDescending(p => p.Value.rarity).ThenByDescending(p => p.Value.averageRate))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.averageRate:f2}");
            }
        }
    }
}
