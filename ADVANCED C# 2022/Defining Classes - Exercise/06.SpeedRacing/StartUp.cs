using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            for (int i = 0; i < n; i++)
            {
                var carInformation = Console.ReadLine().Split();
                string carModel = carInformation[0];
                double fuelAmount = double.Parse(carInformation[1]);
                double fuelConsumptionPerKM = double.Parse(carInformation[2]);
                cars.Add(carModel,new Car(carModel, fuelAmount, fuelConsumptionPerKM));
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                var info = command.Split();
                var model = info[1];
                double kmToDrive = double.Parse(info[2]);
                cars[model].Drive(kmToDrive);
                command = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.Value); 
            }
        }
    }
}
