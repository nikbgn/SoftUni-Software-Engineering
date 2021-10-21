using System;

namespace _10._Weather_Forecast___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double weather = double.Parse(Console.ReadLine());
            if(weather >= 26.00 && weather <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            else if(weather >= 20.1 && weather <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            else if (weather >= 15.00 && weather <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (weather >= 12.00 && weather <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (weather >= 5.00 && weather <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
