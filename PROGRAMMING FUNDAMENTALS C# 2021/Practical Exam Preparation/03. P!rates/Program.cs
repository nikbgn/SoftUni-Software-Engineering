using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._P_rates
{

    class Town
    {
        public string TownName { get; set; }
        public int TownPopulation { get; set; }
        public int TownGold { get; set; }

        public bool deadTown = false;

        public void TownPlunder(int people, int gold)
        {
            this.TownPopulation -= people;
            this.TownGold -= gold;
            if (this.TownPopulation <= 0 || this.TownGold <= 0)
            {
                //Disband town
                deadTown = true;
            }
            Console.WriteLine($"{this.TownName} plundered! {gold} gold stolen, {people} citizens killed.");
        }

        public void TownProsper(int goldToProsper)
        {
            this.TownGold += goldToProsper;
            Console.WriteLine($"{goldToProsper} gold added to the city treasury. {this.TownName} now has {this.TownGold} gold.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Town> townsDict = new Dictionary<string, Town>();
            string[] command = Console.ReadLine().Split("||");
            while(command[0] != "Sail")
            {
                string townName = command[0];
                int townPopulation = int.Parse(command[1]);
                int townGold = int.Parse(command[2]);

                if (!townsDict.ContainsKey(townName))
                {
                    townsDict.Add(townName, new Town() { TownName = townName, TownPopulation = townPopulation, TownGold = townGold });
                }
                else
                {
                    townsDict[townName].TownPopulation += townPopulation;
                    townsDict[townName].TownGold += townGold;
                }

                command = Console.ReadLine().Split("||");

            }
            command = Console.ReadLine().Split("=>");
            while(command[0] != "End")
            {
                string currCommand = command[0];
                string town = command[1];

                switch (currCommand)
                {
                    case "Plunder":
                        int people = int.Parse(command[2]);
                        int gold = int.Parse(command[3]);
                        townsDict[town].TownPlunder(people, gold);
                        //Check if we need to disband the town.
                        if (townsDict[town].deadTown)
                        {
                            townsDict.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                        break;
                    case "Prosper":
                        int goldProsper = int.Parse(command[2]);
                        if(goldProsper < 0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                        }
                        else
                        {
                            townsDict[town].TownProsper(goldProsper);
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split("=>");
            }




            if (townsDict.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townsDict.Count} wealthy settlements to go to:");
                foreach (var town in townsDict.OrderByDescending(x => x.Value.TownGold).ThenBy(x => x.Value.TownName))
                {
                    Console.WriteLine($"{town.Value.TownName} -> Population: {town.Value.TownPopulation} citizens, Gold: {town.Value.TownGold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }


        


    }
}
