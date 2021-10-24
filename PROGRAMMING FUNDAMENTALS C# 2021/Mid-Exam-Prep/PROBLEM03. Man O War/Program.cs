using System;
using System.Collections.Generic;
using System.Linq;

namespace PROBLEM03._Man_O_War
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judge Points 100/100
            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maximumHealthCapacity = int.Parse(Console.ReadLine());
            List<string> currentCommand = Console.ReadLine().Split().ToList();

            while (currentCommand[0] != "Retire")
            {
                switch (currentCommand[0])
                {
                    case "Fire":
                        int sectionToShoot = int.Parse(currentCommand[1]);
                        int damageToApply = int.Parse(currentCommand[2]);
                        //Example fire command:
                        //Fire {index} {damage}
                        //Check if the index is valid
                        if (sectionToShoot < 0 || sectionToShoot >= warShip.Count) { break; }
                        else
                        {
                            //Apply damage on the section
                            warShip[sectionToShoot] -= damageToApply;
                            //Check if the ship hasn't sunk. If it did, inform the user, and stop the program.
                            if (warShip[sectionToShoot] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                        break;
                    case "Defend":
                        //Example defend command:
                        //Defend {startIndex} {endIndex} {damage}
                        int startIndex = int.Parse(currentCommand[1]);
                        int endIndex = int.Parse(currentCommand[2]);
                        int damage = int.Parse(currentCommand[3]);

                        //Check if startIndex or endIndex is invalid.
                        bool invalidIndexes = startIndex < 0 || endIndex >= pirateShip.Count || startIndex > endIndex;
                        if (invalidIndexes) { break; }
                        //If they are valid, damage the sections and check for ship sinking.
                        else
                        {
                            for (int i = startIndex; i <= endIndex; i++)
                            {
                                pirateShip[i] -= damage;
                                if(pirateShip[i] <= 0)
                                {
                                    Console.WriteLine("You lost! The pirate ship has sunken.");
                                    return;
                                }
                            }
                        }
                        break;
                    case "Repair":
                        //Example repair command:
                        //Repair {index} {health}
                        int sectionToRepair = int.Parse(currentCommand[1]);
                        int healthToAdd = int.Parse(currentCommand[2]);
                        //Check if sectionToRepair is valid
                        if (sectionToRepair < 0 || sectionToRepair >= pirateShip.Count) { break; }
                        else
                        {
                            //Check if healing will result in breaking the MaxHealthCapacity rule, if it goes over maxHealth, just set the sectionToRepair to maxHealth;
                            if (healthToAdd + pirateShip[sectionToRepair] > maximumHealthCapacity)
                            {
                                pirateShip[sectionToRepair] = maximumHealthCapacity;
                            }
                            else
                            {
                                pirateShip[sectionToRepair] += healthToAdd;
                            }
                        }
                        break;
                    case "Status":
                        //Status command prints all sections of the pirateship that have health lower than 20% of the maxHealthCapacity
                        double checkHealth = maximumHealthCapacity * 0.2; // Calculte 20% of maxHealthCapacity
                        int sectionsThatNeedRepairCount = 0;
                        foreach (int section in pirateShip)
                        {
                            if (section < checkHealth)
                            {
                                sectionsThatNeedRepairCount += 1;
                            }
                        }


                        Console.WriteLine($"{sectionsThatNeedRepairCount} sections need repair.");

                        break;
                    default:
                        break;
                }


                currentCommand = Console.ReadLine().Split().ToList();
            }


            //If no ship sank, during the fights we have a stalemate.

            Console.WriteLine($"Pirate ship status: {getShipSum(pirateShip)}");
            Console.WriteLine($"Warship status: {getShipSum(warShip)}");
            

        }

        private static int getShipSum(List<int> ship)
        {
            int sum = 0;
            foreach (int section in ship)
            {
                sum += section;
            }

            return sum;
        }
    }
}
