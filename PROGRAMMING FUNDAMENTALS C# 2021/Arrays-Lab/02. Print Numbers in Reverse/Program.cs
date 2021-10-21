using System;

namespace _02._Print_Numbers_in_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
            }


            for (int k = arr.Length - 1; k >= 0; k--)
            {
                Console.Write($"{arr[k]} ");
            }

        }
    }
}
