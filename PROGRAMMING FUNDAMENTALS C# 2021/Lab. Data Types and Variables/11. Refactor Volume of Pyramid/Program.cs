using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double lenght = double.Parse(Console.ReadLine());

            double width = double.Parse(Console.ReadLine());

            double height = double.Parse(Console.ReadLine());
            double result = lenght/3 * width * height;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {result:f2}");

        }
    }
}
