using System;

namespace _05._Divide_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;

            for (int i = 1; i <=n; i++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value % 2 == 0)
                {
                    group1++;
                }
                if (value % 3 == 0)
                {
                    group2++;
                }
                if (value % 4 == 0)
                {
                    group3++;
                }

            }



            double p1 = group1 * 1.0 / n * 100;
            double p2 = group2 * 1.0 / n * 100;
            double p3 = group3 * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
