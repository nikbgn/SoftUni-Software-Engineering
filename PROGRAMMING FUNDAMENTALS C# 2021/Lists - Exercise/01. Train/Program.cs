using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {

                string[] command = Console.ReadLine().Split();


                //Ako imame end -> break

                if (command[0] == "end") { break; }

                //Ako command.Length e ravna na 2, znachi imame Add X

                if (command.Length == 2)
                {
                    string addArgument = command[0];
                    int commandValue = int.Parse(command[1]);

                    //Add a new wagon at the end of the train
                    wagons.Add(commandValue);
                }

                // Ako command.Length != 2 , znachi imame X passangers , koito trqbva da nastanim.
                else
                {
                    //Algorithm
                    //Za vseki vagon
                    //Ako pasajerite koito iskame da nastanim + pasajerite vuv vagona > maxCapacity, proverqvqme sledvashtiq vagon.
                    int passengersWithoutSeat = int.Parse(command[0]);
                    findSpotForNewPassengers(maxCapacity, passengersWithoutSeat, wagons);

                }



            }

            Console.WriteLine(string.Join(" ",wagons));
        }

        private static void findSpotForNewPassengers(int maxCapacity, int toFindSeatPassengers, List<int> wagons)
        {

            for (int i = 0; i < wagons.Count; i++)
            {
                if(toFindSeatPassengers + wagons[i] <= maxCapacity)
                {
                    wagons[i] += toFindSeatPassengers;
                    return;
                }


            }
        }
    }
}
