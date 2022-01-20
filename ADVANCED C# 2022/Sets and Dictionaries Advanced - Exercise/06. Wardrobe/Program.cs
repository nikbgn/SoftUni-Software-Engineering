using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] currLine = Console.ReadLine().Split(" -> ");
                string color = currLine[0];
                string[] clothes = currLine[1].Split(",");
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                foreach (var clth in clothes)
                {
                    if (!dict[color].ContainsKey(clth))
                    {
                        dict[color].Add(clth, 0);
                    }
                    dict[color][clth]++;
                }

            }

            string[] lookingFor = Console.ReadLine().Split();
            string lookingForcolor = lookingFor[0];
            string lookingForCloth = lookingFor[1];
            foreach (var color in dict)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var clothItem in color.Value)
                {
                    if (clothItem.Key == lookingForCloth && color.Key == lookingForcolor) Console.WriteLine($"* {clothItem.Key} - {clothItem.Value} (found!)");
                    else Console.WriteLine($"* {clothItem.Key} - {clothItem.Value}");
                }
            }
        }
    }
}
