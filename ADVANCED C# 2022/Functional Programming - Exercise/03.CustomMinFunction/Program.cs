using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestNumFinder = arr =>
             {
                 int min = int.MaxValue;
                 for (int i = 0; i < arr.Length; i++)
                 {
                     if (min > arr[i]) min = arr[i];
                 }
                 return min;
             };


            int[] numsArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine(smallestNumFinder(numsArr));


        }
    }
}
