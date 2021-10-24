using System;
using System.Collections.Generic;
using System.Linq;

namespace _02PROBLEM___The_Lift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleWithoutSeat = int.Parse(Console.ReadLine());
            int[] train = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int maxCapacityOfAWagon = 4;

            while (true)
            {
                //Fill the train...
                for (int i = 0; i < train.Length; i++)
                {
                    int placesToFill = 0;
                    if (train[i] != maxCapacityOfAWagon)
                    {
                        if (peopleWithoutSeat < maxCapacityOfAWagon)
                        {
                            train[i] += peopleWithoutSeat;
                            peopleWithoutSeat -= peopleWithoutSeat;
                        }
                        else
                        {
                            placesToFill = maxCapacityOfAWagon - train[i];
                            train[i] += placesToFill;
                            peopleWithoutSeat -= placesToFill;
                        }

                    }

                }

                break;

            }


            if (peopleWithoutSeat == 0 && checkForEmptyWagons(train) == false)
            {
                Console.WriteLine(string.Join(" ", train));
            }

            else if (checkForEmptyWagons(train))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", train));

            }
            else
            {
                Console.WriteLine($"There isn't enough space! {peopleWithoutSeat} people in a queue!");
                Console.WriteLine(string.Join(" ", train));
            }

        }


        static bool checkForEmptyWagons(int[] train)
        {
            bool hasEmplySpots = false;
            foreach (int wagon in train)
            {
                if (wagon != 4) { hasEmplySpots = true; break; }
            }
            return hasEmplySpots;
        }





    }
}
