using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person TestPerson = new Person() { Name = "Peter", Age = 20 };
            Console.WriteLine($"{TestPerson.Name}\n{TestPerson.Age}");
        }
    }
}
