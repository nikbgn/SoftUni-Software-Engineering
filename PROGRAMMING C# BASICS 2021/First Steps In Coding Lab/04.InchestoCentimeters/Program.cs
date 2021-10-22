using System;

namespace _04.InchestoCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double multiplayer = 2.54;
            double centimeters = inches * multiplayer;
            Console.WriteLine(centimeters);
        }
    }
}
