using System;

namespace _06._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side*side:F3}");
            }
            else if (figure == "rectangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine($"{w*h:F3}");

            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                double result = Math.PI * Math.Pow(r, 2);
                Console.WriteLine($"{result:F3}");
            }
            else
            {
                double sideC = double.Parse(Console.ReadLine());
                double cH = double.Parse(Console.ReadLine());
                double res = (sideC*cH)/ 2;
                Console.WriteLine($"{res:F3}");

            }
        }
    }
}
