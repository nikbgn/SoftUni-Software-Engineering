using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            string[] arr1 = new string[numOfLines];
            string[] arr2 = new string[numOfLines];
            string[] inputs = new string[numOfLines * 2];

            for (int i = 0; i < numOfLines; i++)
            {
                inputs = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arr1[i] = inputs[0];
                    arr2[i] = inputs[1];
                }
                else
                {
                    arr1[i] = inputs[1];
                    arr2[i] = inputs[0];
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
