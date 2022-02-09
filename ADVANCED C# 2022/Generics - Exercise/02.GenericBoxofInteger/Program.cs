using System;

namespace _02.GenericBoxofInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfStringsToRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStringsToRead; i++)
            {
                Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
                Console.WriteLine(box);
            }

        }
    }
}
