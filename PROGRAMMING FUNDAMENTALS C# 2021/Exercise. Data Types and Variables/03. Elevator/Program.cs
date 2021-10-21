using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int perons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int result = (int)Math.Ceiling((double)perons/capacity);
            Console.WriteLine(result);
        }
    }
}
