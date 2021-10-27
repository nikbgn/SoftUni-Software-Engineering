using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Student> students = new List<Student>();
            while (command[0] != "end")
            {
                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string homeTown = command[3];

                Student currentStudent = new Student() { Name = firstName, LastName = lastName, Age = age, HomeTown = homeTown };
                students.Add(currentStudent);
                command = Console.ReadLine().Split();
            }
            string cityFilter = Console.ReadLine();

            List<Student> studentsToPrint = students.Where(studentToPrint => studentToPrint.HomeTown == cityFilter).ToList();
            foreach (Student student in studentsToPrint)
            {
                Console.WriteLine(student.PrintStudentInfo());
            }
        }
    }

    class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


        public string PrintStudentInfo()
        {
            return $"{Name} {LastName} is {Age} years old.";
        }
    }
}
