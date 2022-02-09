using System;

namespace _05.GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                var element = Console.ReadLine();
                box.Items.Add(element);

            }

            Console.WriteLine(box.CountBiggerThan(Console.ReadLine()));


        }
    }
}
