using System;

namespace _01._Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double poolWaterLiters = P1 * H + P2 * H;
            double poolWaterPercentage = poolWaterLiters / V;

            double firstPipe = (P1 * H) / poolWaterLiters ;
            double secondPipe = (P2 * H) / poolWaterLiters;

            if (poolWaterLiters < V)
            {
                Console.WriteLine($"The pool is {poolWaterPercentage * 100:F2}% full. Pipe 1: {firstPipe * 100:F2}%. Pipe 2: {secondPipe * 100:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {poolWaterLiters - V:F2} liters.");
            }

            
        }
    }
}
