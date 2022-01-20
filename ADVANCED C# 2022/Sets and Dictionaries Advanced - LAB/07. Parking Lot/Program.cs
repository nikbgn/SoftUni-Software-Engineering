using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string direction = command[0];
                if (direction == "END") break;

                string numberPlate = command[1];


                if (direction == "IN")
                {
                    parkingLot.Add(numberPlate);
                }
                else if (direction == "OUT")
                {
                    parkingLot.Remove(numberPlate);
                }
            }


            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }


        }
    }
}
