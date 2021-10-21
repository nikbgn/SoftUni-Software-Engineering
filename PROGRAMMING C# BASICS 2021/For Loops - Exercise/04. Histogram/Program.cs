using System;

namespace _04._Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            int group4 = 0;
            int group5 = 0;


            for (int i = 1; i <=n; i++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value < 200)
                {
                    group1++;
                }
                else if (value >= 200 && value <= 399)
                {
                    group2++;
                }
                else if (value >= 400 && value <= 599)
                {
                    group3++;
                }
                else if (value >= 600 && value <= 799)
                {
                    group4++;
                }
                else if (value >= 800)
                {
                    group5++;
                }
            }

            double p1 = group1*1.0 / n * 100;
            double p2 = group2*1.0 / n * 100;
            double p3 = group3*1.0 / n * 100;
            double p4 = group4*1.0 / n * 100;
            double p5 = group5*1.0 / n * 100;
            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
