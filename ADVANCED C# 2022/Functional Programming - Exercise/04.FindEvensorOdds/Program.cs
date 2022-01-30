using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensorOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string flag = Console.ReadLine().ToLower();
            List<int> nums = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                nums.Add(i);
            }

            Predicate<int> isEven = num => num % 2 == 0;
            Predicate<int> isOdd = num => num % 2 != 0;
            if (flag == "even" )
            {
                List<int> res = nums.FindAll(isEven);
                Console.WriteLine(string.Join(" ",res));
            }
            else
            {
                List<int> res = nums.FindAll(isOdd);
                Console.WriteLine(string.Join(" ", res));
            }

        }
    }
}
