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
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = line[0];
                int power = int.Parse(line[1]);

                Engine engine = new Engine() 
                {
                    Model = model,
                    Power = power,
                };

                if (line.Length == 4)
                {
                    int displacement = int.Parse(line[2]);
                    string efficiency = line[3];
                    engine.Displacement = displacement;
                    engine.Efficiency = efficiency;
                }

                else if (line.Length == 3)
                {
                    bool isDisplacement = int.TryParse(line[2], out var disp);

                    if (isDisplacement)
                    {
                        engine.Displacement = disp;
                    }
                    else
                    {
                        engine.Efficiency = line[2];
                    }
                }


                engines.Add(engine);

            }


            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var line = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string model = line[0];
                string engine = line[1];

                Engine lookUp = engines.FirstOrDefault(x=>x.Model == engine);

                Car car = new Car
                {
                    Model = model,
                    Engine = lookUp
                };

                if (line.Length == 4)
                {
                    int weight = int.Parse(line[2]);
                    string color = line[3];
                    car.Weight = weight;
                    car.Color = color;
                }
                else if(line.Length == 3)
                {
                    bool isWeight = int.TryParse(line[2], out int res);

                    if (isWeight)
                    {
                        car.Weight = res;
                    }
                    else
                    {
                        car.Color = line[2];
                    }
                }

                cars.Add(car);
            }


            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"   Power: {car.Engine.Power}");

                string displacementInfo = car.Engine.Displacement.HasValue?
                    $"   Displacement: {car.Engine.Displacement}":
                    $"   Displacement: n/a";

                string efficiencyInfo = car.Engine.Efficiency != null ?
                    $"   Efficiency: {car.Engine.Efficiency}" :
                    $"   Efficiency: n/a";


                string weightInfo = car.Weight.HasValue ?
                    $"   Weight: {car.Weight}" :
                    $"   Weight: n/a";

                string colorInfo = car.Color != null ?
                    $"Color: {car.Color}" :
                    $"Color: n/a";

                Console.WriteLine(displacementInfo);
                Console.WriteLine(efficiencyInfo);
                Console.WriteLine(weightInfo);
                Console.WriteLine(colorInfo);


            }

        }
    }
}
