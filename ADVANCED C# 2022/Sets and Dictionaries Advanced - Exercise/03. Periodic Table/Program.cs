using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> chemicals = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] currLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in currLine)
                {
                    chemicals.Add(item);
                }
            }

            Console.WriteLine(string.Join(" ", chemicals.OrderBy(ascending => ascending)));
        }
    }
}
