
using System;
using System.Collections.Generic;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int m = int.Parse(nums[1]);
            HashSet<int> setN = new HashSet<int>();
            HashSet<int> setM = new HashSet<int>();
            

            for (int i = 0; i < n+m; i++)
            {
                if(i < n)
                {
                    setN.Add(int.Parse(Console.ReadLine()));
                }
                else
                {
                    setM.Add(int.Parse(Console.ReadLine()));
                }
            }
            HashSet<int> finalSet = new HashSet<int>(setN);
            finalSet.IntersectWith(setM);
            Console.WriteLine(string.Join(" ", finalSet)); 

        }
    }
}
