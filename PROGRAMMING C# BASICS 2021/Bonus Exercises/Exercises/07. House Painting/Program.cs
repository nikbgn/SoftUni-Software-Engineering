using System;

namespace _07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double pages = 2 * sideWall - 2 * window;
            double backWall = x * x;
            double enterance = 1.2 * 2;
            double backAndFront = 2 * backWall - enterance;
            double final = pages + backAndFront;
            double greenPaint = final / 3.4;
            double twoRoofRects = 2 * (x * y);
            double twoRoofTriangles = 2 * (x * h/2);
            double finalRoof = twoRoofRects + twoRoofTriangles;
            double redPaint = finalRoof / 4.3;
            Console.WriteLine($"{greenPaint:F2}");
            Console.WriteLine($"{redPaint:F2}");

        }
    }
}
