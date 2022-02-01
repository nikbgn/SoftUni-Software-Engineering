using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            List<Tire[]> carsTireList = new List<Tire[]>();
            List<Engine> carsEngineList = new List<Engine>();
            List<Car> cars = new List<Car>();
            string input = Console.ReadLine();
            while (input != "No more tires")
            {
                string[] tireInfo = input.Split();
                Tire[] tireArr = new Tire[4]
                {
                    new Tire(int.Parse(tireInfo[0]), double.Parse(tireInfo[1])),
                    new Tire(int.Parse(tireInfo[2]), double.Parse(tireInfo[3])),
                    new Tire(int.Parse(tireInfo[4]), double.Parse(tireInfo[5])),
                    new Tire(int.Parse(tireInfo[6]), double.Parse(tireInfo[7]))
                };

                carsTireList.Add(tireArr);
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Engines done")
            {
                string[] engineInfo = input.Split();
                int power = int.Parse(engineInfo[0]);
                double capacity = double.Parse(engineInfo[1]);
                carsEngineList.Add(new Engine(power, capacity));
                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "Show special")
            {
                string[] carInfo = input.Split();
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQty = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                Engine engine = carsEngineList[int.Parse(carInfo[5])];
                Tire[] tiresArr = carsTireList[int.Parse(carInfo[6])];
                cars.Add(new Car(make, model, year, fuelQty, fuelConsumption, engine, tiresArr));
                input = Console.ReadLine();
            }

            List<Car> outputCars = cars.Where(Car.FilterCars()).ToList();

            foreach (var car in outputCars)
            {
                car.Drive(20);
                Console.Write(car);
            }


        }
    }
}