using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();
            for (int i = 0; i < numOfStudents; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName,new List<double>() { studentGrade });
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
                
            }


            foreach (var student in students.OrderByDescending(student => student.Value.Average()).Where(student => student.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
