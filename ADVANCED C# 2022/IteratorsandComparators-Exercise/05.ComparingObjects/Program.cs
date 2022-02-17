using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace _05.ComparingObjects
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while (input != "END")
            {
                string[] tokens = input.Split();
                people.Add(new Person(tokens[0], int.Parse(tokens[1]), tokens[2]));
                input = Console.ReadLine();
            }

            int equal = 0;
            int lower = 0;

            Person comparePerson = people[int.Parse(Console.ReadLine()) - 1];
            foreach (Person person in people)
            {
                if (comparePerson.CompareTo(person) == 0) equal++;
                else lower++;
            }

            Console.WriteLine(equal > 1
                ? $"{equal} {lower} {people.Count}"
                : "No matches");
        }
    }



    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }

        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Town { get; private set; }

        public int CompareTo(Person other)
        {
            int result = Name.CompareTo(other.Name);
            if (result == 0) result = Age.CompareTo(other.Age);
            if (result == 0) result = Town.CompareTo(other.Town);

            return result;
        }
    }
}
