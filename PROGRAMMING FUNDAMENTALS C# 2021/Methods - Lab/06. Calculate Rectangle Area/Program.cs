﻿using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(calculateRectangleArea(a, b)); 
        }
        

        static int calculateRectangleArea(int a,int b)
        {
            return a * b;
        }

    }
}
