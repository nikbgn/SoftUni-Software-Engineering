using System;
using System.Collections.Generic;
using System.Linq;

namespace _03PROBLEM___Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judge Points 100/100

            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            double average = averageArr(arr);
            List<int> numsHigherThanAverage = highestThanAverageNums(average, arr);
            List<int> five = new List<int>();
            if (numsHigherThanAverage.Count == 0)
            {
                Console.WriteLine("No");
            }
            else if(numsHigherThanAverage.Count >= 5)
            {
                numsHigherThanAverage.Sort();
                numsHigherThanAverage.Reverse();
                for (int i = 0; i < 5; i++)
                {
                    five.Add(numsHigherThanAverage[i]);
                }
                Console.WriteLine(string.Join(" ", five));
            }
            else
            {
                numsHigherThanAverage.Sort();
                numsHigherThanAverage.Reverse();
                Console.WriteLine(string.Join(" ", numsHigherThanAverage));

            }




        }


        static double averageArr(int[] ar)
        {
            double avrg = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                avrg += ar[i];
            }


            return avrg / ar.Length;
        }

        static List<int> highestThanAverageNums(double average, int[] ar)
        {
            List<int> higherThanAverage = new List<int>();
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > average)
                {
                    higherThanAverage.Add(ar[i]);
                }
            }

            return higherThanAverage;
        }
    }
}
