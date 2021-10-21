using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] people = new int[wagons];
            int[] peopleInWagons = new int[people.Length];
            int sum = 0;
            for (int i = 0; i < wagons; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < people.Length; i++)
            {
                peopleInWagons[i] = people[i];
            }
            foreach (int person in people)
            {
                sum += person;
            }
            Console.WriteLine(String.Join(' ', peopleInWagons));
            Console.WriteLine(sum);
        }
    }
}
