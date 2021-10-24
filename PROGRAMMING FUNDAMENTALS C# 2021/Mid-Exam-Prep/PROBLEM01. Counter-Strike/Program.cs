using System;

namespace PROBLEM01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int distance = 0;
            int winCount = 0;
            while(command != "End of battle")
            {
                distance = int.Parse(command);

                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCount} won battles and {energy} energy");
                    return;
                }
                else
                {
                    energy -= distance;
                    winCount++;
                }

                if (winCount % 3 == 0) { energy += winCount; }

                command = Console.ReadLine();

            }


            Console.WriteLine($"Won battles: {winCount}. Energy left: {energy}");
           
        }
    }
}
