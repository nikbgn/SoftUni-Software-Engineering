using System;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                var element = double.Parse(Console.ReadLine());
                box.Items.Add(element);

            }

            Console.WriteLine(box.CountBiggerThan(double.Parse(Console.ReadLine())));


        }
    }
}
