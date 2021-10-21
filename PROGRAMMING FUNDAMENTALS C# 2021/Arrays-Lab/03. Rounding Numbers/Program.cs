using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[array.Length];



            for (int i = 0; i < array.Length; i++)
            {
                roundedNums[i] = Convert.ToInt32(Math.Round(array[i], MidpointRounding.AwayFromZero));
            }



            for (int i = 0; i < roundedNums.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {roundedNums[i]}");
            }

        }
    }
}
