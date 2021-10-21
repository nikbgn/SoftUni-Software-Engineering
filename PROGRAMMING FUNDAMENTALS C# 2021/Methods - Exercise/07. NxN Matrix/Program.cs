using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(createMatrixOfNum(number));
        }


        static string createMatrixOfNum(int number)
        {
            string matrix = string.Empty;
            for (int cols = 0; cols < number; cols++)
            {
                for (int rows = 0; rows < number; rows++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }

            return matrix;
        }

    }
}
