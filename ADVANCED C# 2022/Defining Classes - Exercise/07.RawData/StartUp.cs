using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var info = Console.ReadLine().Split();
                string model = info[0];
                int engineSpeed = int.Parse(info[1]);
                int enginePower = int.Parse(info[2]);
                int cargoWeight = int.Parse(info[3]);
                string cargoType = info[4];

                float tire1Pressure = float.Parse(info[5]);
                int tire1Age = int.Parse(info[6]);

                float tire2Pressure = float.Parse(info[7]);
                int tire2Age = int.Parse(info[8]);

                float tire3Pressure = float.Parse(info[9]);
                int tire3Age = int.Parse(info[10]);

                float tire4Pressure = float.Parse(info[11]);
                int tire4Age = int.Parse(info[12]);

                Engine currentEngine = new Engine(engineSpeed, enginePower);
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4]
                {
                    new Tire(tire1Age,tire1Pressure),
                    new Tire(tire2Age,tire2Pressure),
                    new Tire(tire3Age,tire3Pressure),
                    new Tire(tire4Age,tire4Pressure),
                };
                Car currentCar = new Car(model, currentEngine, currentCargo, tires);
                cars.Add(currentCar);

            }
            List<Car> lowPressureCars = cars.Where(x=>Tire.hasLowPressureTire(x)).ToList();

            string filter = Console.ReadLine();

            if (filter == "fragile")
            {
                foreach (var car in lowPressureCars.Where(x => x.Cargo.CargoType == "fragile"))
                {
                    car.PrintModel();
                }
                
            }
            else
            {
                foreach (var car in cars.Where(x=>x.Cargo.CargoType== "flammable").Where(x=>x.Engine.Power > 250))
                {
                    car.PrintModel();
                }
            }


        }
    }
}
