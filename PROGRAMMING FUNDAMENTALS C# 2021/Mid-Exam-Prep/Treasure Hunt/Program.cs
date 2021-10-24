using System;
using System.Collections.Generic;
using System.Linq;

namespace Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {

            //Judge Points 100/100

            List<string> chest = Console.ReadLine().Split("|").ToList(); //Initial loot.
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Yohoho!")
            {
                string action = command[0]; //Action could be : Loot, Drop, Steal

                switch (action)
                {
                    case "Loot":
                        command.Remove("Loot");
                        foreach (string item in command)
                        {
                            if (chest.Contains(item) == false)
                            {
                                chest.Insert(0, item);
                            }
                        }
                        break;
                    case "Drop":

                        int indexProvided = int.Parse(command[1]);

                        if (indexProvided >= chest.Count || indexProvided < 0)
                        {
                            break;
                        }
                        else
                        {
                            string addToEnd = chest[indexProvided];
                            chest.RemoveAt(indexProvided);
                            chest.Add(addToEnd);
                        }
                        break;
                    case "Steal":
                        //Pistol Coins Wood Silver Bronze Medallion Cup Gold
                        //Steal 3 -> Medallion Cup Gold
                        int stealIndex = int.Parse(command[1]);
                        if (stealIndex >= chest.Count)//Maybe >=
                        {
                            Console.WriteLine(string.Join(", ", chest));
                            chest.RemoveRange(0, chest.Count);
                        }
                        else
                        {
                            List<string> resultTxt = new List<string>();
                            for (int i = chest.Count - stealIndex; i < chest.Count; i++)
                            {
                                resultTxt.Add(chest[i]);
                            }

                            foreach (string item in resultTxt)
                            {
                                chest.Remove(item);
                            }

                            Console.WriteLine(string.Join(", ", resultTxt));
                        }

                        break;
                    default:
                        break;

                }

                command = Console.ReadLine().Split().ToList();
            }

            if (chest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {listSum(chest)} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }


        }

        static string listSum(List<string> provideList)
        {
            double sum = 0;
            foreach (string item in provideList)
            {
                sum += item.Length;
            }

            return $"{sum / provideList.Count:f2}";
        }
    }
}
