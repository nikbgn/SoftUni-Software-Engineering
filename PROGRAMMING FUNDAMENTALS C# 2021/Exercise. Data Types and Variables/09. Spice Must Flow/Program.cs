using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spices = 0;
            int days = 0;
            while (yield >= 100)
            {
                spices += yield;
                spices -= 26;
                days += 1;
                yield -= 10;
            }


            if (days <= 0) { Console.WriteLine(0); Console.WriteLine(0); }
            else { Console.WriteLine( days); Console.WriteLine(spices - 26); }
        }
    }
}
