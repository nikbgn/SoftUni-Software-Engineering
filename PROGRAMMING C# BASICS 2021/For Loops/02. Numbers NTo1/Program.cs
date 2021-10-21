using System;

namespace _02._Numbers_NTo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (; num >= 1; num--) {
                Console.WriteLine(num);
            
            }
        }
    }
}
