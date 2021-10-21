using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int kNum = 0;

            while (kNum <= num)
            {
                kNum = kNum * 2 + 1;
                if (kNum <= num)
                {
                    Console.WriteLine(kNum);
                }
            }

        }
    }
}
