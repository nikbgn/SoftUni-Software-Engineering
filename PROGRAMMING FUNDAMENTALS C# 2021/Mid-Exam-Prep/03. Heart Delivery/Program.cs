using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {

            //Judge Points 100/100

            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            int currentPosition = 0;
            while (true)
            {
                string[] command = Console.ReadLine().Split();

                //If command len is 2 , we know that we have Jump {jump lenght} command, else we know its Love! which should break out of the while loop.
                if(command.Length == 2)
                {
                    int jumpCmd = int.Parse(command[1]);
                    currentPosition += jumpCmd;
                }

                else
                {
                    break;
                }

                
                //Add the jump lenght to our current position.
                
                //If our current position is outside of the box, reset it to starting position.
                if (currentPosition > neighborhood.Count - 1)
                {
                    currentPosition = 0;
                }

                //Check if the house at currentPos already had a valentine's day.
                if (neighborhood[currentPosition] == 0)
                {
                    Console.WriteLine($"Place {currentPosition} already had Valentine's day.");
                }
                //If that place didn't have its Valentine's day already, reduce needed hearts by 2 and check if the new value of needed hearts hits 0, if it hits, then the house finally has its valentine's day
                else
                {
                    neighborhood[currentPosition] -= 2;
                    if (neighborhood[currentPosition] == 0)
                    {
                        Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                    }
                }

            }


            Console.WriteLine($"Cupid's last position was {currentPosition}.");
            int failedPlaces = 0;
            for (int i = 0; i < neighborhood.Count; i++)
            {

                if (neighborhood[i] != 0)
                {
                    failedPlaces++;
                }
            }

            if (failedPlaces > 0)
            {
                Console.WriteLine($"Cupid has failed {failedPlaces} places.");
            }
            else
            {
                Console.WriteLine("Mission was successful.");

            }

        }
    }
}