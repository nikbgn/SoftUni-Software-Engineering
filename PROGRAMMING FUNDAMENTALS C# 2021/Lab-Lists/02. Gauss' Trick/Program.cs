using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int originalLength = list.Count;
            for (int i = 0; i < originalLength / 2; i++)
            {

                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);


            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}
