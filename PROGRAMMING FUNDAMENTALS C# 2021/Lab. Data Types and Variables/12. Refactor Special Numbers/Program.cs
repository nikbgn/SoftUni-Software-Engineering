using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool isSpecialNum = false;
            for (int ch = 1; ch <= nums; ch++)
            {
                digit = ch;
                while (ch > 0)
                {
                    sum += ch % 10;
                    ch = ch / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", digit, isSpecialNum);
                sum = 0;
                ch = digit;
            }

        }
    }
}
