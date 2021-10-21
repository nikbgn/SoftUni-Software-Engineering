using System;

namespace _05._Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.Write("+");
            for (int topPartLoop = 1; topPartLoop <= N-2; topPartLoop++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
            Console.WriteLine();

            for (int midPartMainLoop = 1; midPartMainLoop <= N-2; midPartMainLoop++)
            {
                Console.Write("| ");
                for (int midSmallLoop = 1; midSmallLoop <= N - 2; midSmallLoop++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+");
            for (int BottomLoop = 1; BottomLoop <= N - 2; BottomLoop++)
            {
                Console.Write(" -");
            }
            Console.Write(" +");
        }
    }
}
