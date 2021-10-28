using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split("/");
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            Catalog vehicles = new Catalog(trucks, cars);
            while (command[0] != "end")
            {
                string typeOfVehicle = command[0];
                string brandOfVehicle = command[1];
                string modelOfVehicle = command[2];
                double horsePowersOrWeight = double.Parse(command[3]); //HP for cars, Weight for trucks.

                //Input is always Car or Truck until we recieve "end"

                if (typeOfVehicle == "Car")
                {
                    Car currentCar = new Car()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        HorsePower = horsePowersOrWeight
                    };

                    cars.Add(currentCar);
                }
                else
                {
                    Truck currentTruck = new Truck()
                    {
                        Brand = brandOfVehicle,
                        Model = modelOfVehicle,
                        Weight = horsePowersOrWeight
                    };

                    trucks.Add(currentTruck);

                }

                command = Console.ReadLine().Split("/");

            }
            if (vehicles.Cars.Count != 0)
            {
                vehicles.DisplayCars();
            }
            if (vehicles.Trucks.Count != 0)
            {
                vehicles.DisplayTrucks();
            }


        }
    }



    class Truck
    {
        public string Brand { get; set; }

        public string Model { get; set; }

        public double Weight { get; set; }
    }


    class Car
    {

        public string Brand { get; set; }

        public string Model { get; set; }

        public double HorsePower { get; set; }

    }

    class Catalog
    {

        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            this.Trucks = trucks;
            this.Cars = cars;
        }

        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }


        public void DisplayCars()
        {
            Console.WriteLine("Cars:");
            
            foreach (var car in Cars.OrderBy(x => x.Brand))
            {

                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
        }

        public void DisplayTrucks()
        {
            Console.WriteLine("Trucks:");
            foreach (var truck in Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }


    }
}
