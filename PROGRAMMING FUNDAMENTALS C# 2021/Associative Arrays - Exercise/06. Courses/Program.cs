using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>(); //Course, list of students in the course

            string[] command = Console.ReadLine().Split(" : ");
            while(command[0] != "end")
            {
                string courseName = command[0];
                string studentName = command[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>() { studentName};
                }
                else
                {
                    courses[courseName].Add(studentName);
                }

                command = Console.ReadLine().Split(" : ");

            }

            foreach (var course in courses.OrderByDescending(courseRegisteredUsers => courseRegisteredUsers.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value.OrderBy(name => name))
                {
                    Console.WriteLine($"-- {student}");
                }
                
            }

        }
    }
}
