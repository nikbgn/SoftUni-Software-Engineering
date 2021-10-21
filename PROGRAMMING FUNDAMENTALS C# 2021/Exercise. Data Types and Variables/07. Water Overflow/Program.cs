using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int CAPACITY = 255;

            byte watersToPour = byte.Parse(Console.ReadLine());
            int pouredWater = 0;
            int sumOfLiters = 0;


            while (watersToPour > 0)
            {
                int liters = int.Parse(Console.ReadLine());
                sumOfLiters += liters;
                if (sumOfLiters > CAPACITY) { Console.WriteLine("Insufficient capacity!"); sumOfLiters -= liters; }
                else { pouredWater += liters; }           
                watersToPour -= 1;
            }

            Console.WriteLine(pouredWater);
        }
    }
}
