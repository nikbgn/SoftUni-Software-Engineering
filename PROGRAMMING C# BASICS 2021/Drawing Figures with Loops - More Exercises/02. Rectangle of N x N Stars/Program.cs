using System;

namespace _02._Rectangle_of_N_x_N_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string Stars = new String('*', N);
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(Stars);
            }
        }
    }
}
