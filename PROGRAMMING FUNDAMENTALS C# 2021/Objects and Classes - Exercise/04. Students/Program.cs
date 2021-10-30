using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }
        public static void DisplayStudentInfo(Student student) => Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> studentsList = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                Student studentToAdd = new Student()
                {
                    FirstName = studentInfo[0],
                    LastName = studentInfo[1],
                    Grade = double.Parse(studentInfo[2])
                };
                studentsList.Add(studentToAdd);
            }

            foreach (var student in studentsList.OrderByDescending(student=>student.Grade))
            {
                Student.DisplayStudentInfo(student);
            }

        }
    }
}
