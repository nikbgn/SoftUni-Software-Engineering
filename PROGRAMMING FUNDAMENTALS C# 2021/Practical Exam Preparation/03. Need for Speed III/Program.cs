using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{

    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public string Model { get; set; }
        public int Fuel { get; set; }
        public int Mileage { get; set; }

        public const int MAXFUELCAPACITY = 75;

        public void Drive(int distance, int fuel)
        {
            if (Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
            else
            {
                Mileage += distance;
                Fuel -= fuel;
                Console.WriteLine($"{Model} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
            }


        }

        public void Refuel(int fuel)
        {
            if (fuel + Fuel > 75)
            {
                int toRefuel = Math.Abs(fuel - MAXFUELCAPACITY);
                Fuel += toRefuel;
                Console.WriteLine($"{Model} refueled with {toRefuel} liters");
            }
            else
            {
                Fuel += fuel;
                Console.WriteLine($"{Model} refueled with {fuel} liters");
            }

        }

        public void Revert(int kilometers)
        {
            Mileage -= kilometers;
            if (Mileage < 10000)
            {
                Mileage = 10000;
            }
            else
            {

                Console.WriteLine($"{Model} mileage decreased by {kilometers} kilometers");
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> carsInPossesion = new List<Car>();
            //Fill our garage with cars
            for (int i = 0; i < numOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|");
                carsInPossesion.Add(new Car(carInfo[0], int.Parse(carInfo[1]), int.Parse(carInfo[2])));
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] cmds = command.Split(" : ");
                string currCommand = cmds[0];
                string carToDrive = cmds[1];
                switch (currCommand)
                {
                    case "Drive":
                        int distance = int.Parse(cmds[2]);
                        int fuel = int.Parse(cmds[3]);
                        foreach (var car in carsInPossesion)
                        {
                            if (car.Model == carToDrive)
                            {
                                car.Drive(distance, fuel);
                                if (car.Mileage >= 100000)
                                {
                                    Console.WriteLine($"Time to sell the {car.Model}!");
                                    carsInPossesion.Remove(car);
                                }
                                break;
                            }
                        }
                        break;
                    case "Refuel":
                        int fuelToAdd = int.Parse(cmds[2]);
                        foreach (var car in carsInPossesion)
                        {
                            if (car.Model == carToDrive)
                            {
                                car.Refuel(fuelToAdd);
                                break;
                            }
                        }
                        break;
                    case "Revert":
                        int kilometers = int.Parse(cmds[2]);
                        foreach (var car in carsInPossesion)
                        {
                            if (car.Model == carToDrive)
                            {
                                car.Revert(kilometers);
                                break;
                            }
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }

            foreach (var car in carsInPossesion.OrderByDescending(c => c.Mileage).ThenBy(c => c.Model))
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }


        }
    }
}
