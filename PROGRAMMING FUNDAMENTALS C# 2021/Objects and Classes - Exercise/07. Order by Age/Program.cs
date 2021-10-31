using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.Id = id;
            this.Age = age;
        }

        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public void PrintMyInfo() => Console.WriteLine($"{Name} with ID: {Id} is {Age} years old.");
    }


    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();
            List<Person> people = new List<Person>();
            while (command[0] != "End")
            {
                string name = command[0];
                string id = command[1];
                int age = int.Parse(command[2]);
                if (people.Where(personID => personID.Id == id).Count() > 0)
                {
                    var personToOverwrite = people.First(personID => personID.Id == id);
                    personToOverwrite.Name = name;
                    personToOverwrite.Age = age;
                }
                else
                {
                    people.Add(new Person(name, id, age));
                }


                command = Console.ReadLine().Split();
            }

            foreach (var person in people.OrderBy(person => person.Age))
            {
                person.PrintMyInfo();
            }

        }
    }
}
