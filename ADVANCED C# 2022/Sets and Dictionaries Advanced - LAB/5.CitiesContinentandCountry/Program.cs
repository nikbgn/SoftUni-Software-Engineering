using System;
using System.Collections.Generic;

namespace _5.CitiesContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> dict = new Dictionary<string, Dictionary<string, List<string>>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string continent = command[0];
                string country = command[1];
                string city = command[2];

                if (!dict.ContainsKey(continent))
                {
                    dict.Add(continent, new Dictionary<string, List<string>>());
                    dict[continent].Add(country, new List<string>() { city });
                }
                else if (dict.ContainsKey(continent))
                {
                    if (!dict[continent].ContainsKey(country))
                    {
                        dict[continent].Add(country, new List<string>(){ city});
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }
                }

            }

            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");
                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ",country.Value)}");
                }
            }
        }
    }
}
