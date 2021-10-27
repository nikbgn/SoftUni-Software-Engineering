using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students_2._0
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

                //Check if the students already exists
                if (checkForStudentExistance(students, firstName, lastName))
                {
                    foreach (Student currStudent in students)
                    {
                        //Find the student that already exists and overwrite his data.
                        if (currStudent.Name == firstName && currStudent.LastName == lastName)
                        {
                            currStudent.Age = age;
                            currStudent.HomeTown = homeTown;
                        }
                    }
                }
                else
                {
                    Student currentStudent = new Student()
                    {
                        Name = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };
                    students.Add(currentStudent);
                }

                command = Console.ReadLine().Split();
            }

            
            string cityFilter = Console.ReadLine();


            //Add the students that need to be printed to the studentsToPrint list, based on the cityFilter variable
            List<Student> studentsToPrint = students.Where(studentToPrint => studentToPrint.HomeTown == cityFilter).ToList();
            foreach (Student student in studentsToPrint)
            {
                Console.WriteLine(student.PrintStudentInfo());
            }
        }



        static bool checkForStudentExistance(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.Name == firstName && student.LastName == lastName)
                {
                    return true;
                }
            }
            return false;
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
