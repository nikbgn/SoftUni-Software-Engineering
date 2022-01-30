using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            int divisibleBy = int.Parse(Console.ReadLine());
            Predicate<int> solution = x => x % divisibleBy == 0;
            nums.Reverse();
            nums.RemoveAll(solution);
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
