using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{

    class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string ModelOfVehicle { get; set; }
        public string ColorOfVehicle { get; set; }
        public int HorsePowers { get; set; }

        public void PrintInfo() => Console.WriteLine($"Type: {char.ToUpper(TypeOfVehicle[0]) + TypeOfVehicle.Substring(1)}\nModel: {ModelOfVehicle}\nColor: {ColorOfVehicle}\nHorsepower: {HorsePowers}");
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalog = new List<Vehicle>();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string typeOfVehicle = command[0];
                string modelOfVehicle = command[1];
                string colorOfVehicle = command[2];
                int horsePowers = int.Parse(command[3]);

                Vehicle currVehicle = new Vehicle()
                {
                    TypeOfVehicle = typeOfVehicle,
                    ModelOfVehicle = modelOfVehicle,
                    ColorOfVehicle = colorOfVehicle,
                    HorsePowers = horsePowers
                };

                catalog.Add(currVehicle);
                command = Console.ReadLine().Split();
            }


            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "Close the Catalogue")
                {
                    AverageInfo(catalog);
                    return;
                }
                catalog.First(vehicle => vehicle.ModelOfVehicle == cmd).PrintInfo();
            }

        }


        static void AverageInfo(List<Vehicle> catalog)
        {
            double carAvg = 0;
            double truckAvg = 0;
            int carCount = 0;
            int truckCount = 0;
            foreach (var item in catalog.Where(currentItem => currentItem.TypeOfVehicle == "car"))
            {
                carAvg += item.HorsePowers;
                carCount++;
            }
            foreach (var item in catalog.Where(currItem => currItem.TypeOfVehicle == "truck"))
            {
                truckAvg += item.HorsePowers;
                truckCount++;
            }

            if (carCount > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carAvg / carCount:f2}.");
            }

            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (truckCount > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckAvg / truckCount:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }

        }
    }
}
