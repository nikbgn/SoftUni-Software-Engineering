using System;

namespace _01.ClassBoxData
{
    class StartUp
    {
        static void Main(string[] args)
        {

            try
            {
                double len = double.Parse(Console.ReadLine());
                double wid = double.Parse(Console.ReadLine());
                double hei = double.Parse(Console.ReadLine());
                Box box = new Box(len, wid, hei);
                Console.WriteLine($"Surface Area - {box.SurfaceArea():f2}");
                Console.WriteLine($"Lateral Surface Area - {box.LateralSurfaceArea():f2}");
                Console.WriteLine($"Volume - {box.Volume():f2}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            

        }
    }
}
