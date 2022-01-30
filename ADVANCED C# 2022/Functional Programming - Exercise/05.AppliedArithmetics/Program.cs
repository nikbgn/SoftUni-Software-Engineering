using System;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();

            Action<int[]> add = intArr => 
            {
                for (int i = 0; i < intArr.Length; i++)
                {
                    intArr[i] += 1;
                }
            };

            Action<int[]> multiply = intArr =>
            {
                for (int i = 0; i < intArr.Length; i++)
                {
                    intArr[i] *= 2;
                }
            };

            Action<int[]> subtract = intArr =>
            {
                for (int i = 0; i < intArr.Length; i++)
                {
                    intArr[i] -= 1;
                }
            };

            Action<int[]> Printer = intArr => Console.WriteLine(String.Join(" ",intArr));


            while (command != "end")
            {
                switch (command)
                {
                    case "add":
                        add(nums);
                        break;
                    case "multiply":
                        multiply(nums);
                        break;
                    case "subtract":
                        subtract(nums);
                        break;
                    case "print":
                        Printer(nums);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
        }
    }
}
