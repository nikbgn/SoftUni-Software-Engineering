using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();
                family.AddMember(new Person(personInfo[0], int.Parse(personInfo[1])));
            }


            Person oldest = family.GetOldestPerson();
            
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
