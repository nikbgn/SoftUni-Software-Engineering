using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int,int[],bool> divisibleByDividers = (num,intArr) =>
            {
                for (int i = 0; i < intArr.Length; i++)
                {
                    if (num % intArr[i] != 0) return false;
                }

                return true;
            };
            Func<int, int[], List<int>> listOfPredicates = (range, dividersArr) =>
            {
                List<int> result = new List<int>();
                for (int i = 1; i <= range; i++)
                {
                    if (divisibleByDividers(i, dividersArr)) result.Add(i);
                }

                return result;
            };

            Console.WriteLine(string.Join(" ", listOfPredicates(range, dividers)));
        }
    }
}
