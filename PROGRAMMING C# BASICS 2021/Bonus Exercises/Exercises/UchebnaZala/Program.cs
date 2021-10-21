using System;

namespace UchebnaZala
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            

            double WidthCM = h * 100;
            double HeightCM = w * 100;


            double buroRed = Math.Floor((WidthCM - 100) / 70); //-100 -> Коридор

            double redove = Math.Floor(HeightCM / 120);

            double mesta = buroRed * redove - 3;

            Console.WriteLine(mesta);


        }
    }
}
