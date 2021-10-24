using System;
using System.Linq;

namespace _02.Mu_Online
{
    class Program
    {
        static void Main(string[] args)
        {

            //Judge Points 100/100
            int health = 100;
            int btc = 0;
            int roomCounter = 0;
            string[] dungeonMap = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
            int lastDmgTaken = 0;
            //Console.WriteLine(String.Join(",",dungeonMap));

            foreach (string room in dungeonMap)
            {
                roomCounter += 1;
                string[] currCommand = room.Split();
                switch (currCommand[0])//Switching by the so called "command" -> can be potion,chest or a monster.
                {
                    case "potion":
                        //Take how much we heal by using currCommand[1] and do the calculations...
                        if ((int.Parse(currCommand[1]) + health) > 100)
                        {
                            
                            Console.WriteLine($"You healed for {100-health} hp.");
                            health = 100;
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            health += int.Parse(currCommand[1]);//Here currCommand[1] represents the bitcoins we found.
                            Console.WriteLine($"You healed for {int.Parse(currCommand[1])} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;
                    case "chest":
                        Console.WriteLine($"You found {currCommand[1]} bitcoins.");
                        btc += int.Parse(currCommand[1]);
                        break;
                    default:
                        //By default we are fighting a monster.
                        health -= int.Parse(currCommand[1]); //Here currCommand[1] represents the monster dmg.
                        lastDmgTaken = int.Parse(currCommand[1]); 
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {currCommand[0]}.");
                            Console.WriteLine($"Best room: {roomCounter}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {currCommand[0]}.");
                        }
                        break;
                }

            }

            Console.WriteLine($"You've made it!\nBitcoins: {btc}\nHealth: {health}");
        }
    }
}
