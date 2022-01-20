using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> gradesDict = new Dictionary<string, List<decimal>>();
            for (int i = 0; i < numOfStudents; i++)
            {
                string[] currStudent = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!gradesDict.ContainsKey(currStudent[0]))
                {
                    gradesDict.Add(currStudent[0], new List<decimal>());
                }
                gradesDict[currStudent[0]].Add(decimal.Parse(currStudent[1]));

            }
            foreach (var item in gradesDict)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($" {grade:f2}");
                }
                Console.Write($" (avg: {item.Value.Average():f2})\n");
            }

            
            
        }
    }
}
