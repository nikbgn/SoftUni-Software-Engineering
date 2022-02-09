using System;

namespace _01.GenericBoxofString
{
    public class Program
    {
        static void Main(string[] args)
        {


            int numOfStringsToRead = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfStringsToRead; i++)
            {
                Box<string> box = new Box<string>(Console.ReadLine());
                Console.WriteLine(box);
            }


        }
    }
}
