using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void smallestNum(int a,int b,int c)
        {
            int smallest = int.MaxValue;
            if( a < smallest) { smallest = a; }
            if( b < smallest) { smallest = b; }
            if( c < smallest) { smallest = c; }

            Console.WriteLine(smallest);
        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            smallestNum(a, b, c);
        }
    }
}
