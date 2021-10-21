using System;

namespace Exercise05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int s = sumFirstTwo(a, b);
            Console.WriteLine(thirdNumRemover(s,c));

        }

        static int sumFirstTwo(int v1, int v2)
        {
            return v1 + v2;
        }

        static int thirdNumRemover(int v1, int v2)
        {
            return v1 - v2;
        }
    }
}
