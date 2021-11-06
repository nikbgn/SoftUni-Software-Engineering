using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ Exercise

            List<int> listOfInts = Console.ReadLine().Split().Select(int.Parse).ToList();
            if (listOfInts.Count < 3)
            {
                Console.WriteLine(string.Join(" ",listOfInts));
            }
            else
            {
                listOfInts = listOfInts.OrderByDescending(x => x).ToList();
                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{listOfInts[i]} ");
                }
            }
        }
    }
}
