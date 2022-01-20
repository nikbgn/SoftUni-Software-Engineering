using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Same_Values_in_Arr
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayValues = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();
            foreach (var item in arrayValues)
            {
                if (!dict.ContainsKey(item))
                {
                    dict.Add(item, 0);
                }
                dict[item]++;
            }

            foreach (var value in dict)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }

    }
}
