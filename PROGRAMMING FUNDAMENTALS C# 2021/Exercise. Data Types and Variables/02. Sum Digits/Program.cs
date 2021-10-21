using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0)
            {
                int addNum = num % 10;
                num /= 10;
                sum += addNum;

            }

            Console.WriteLine(sum);


        }
    }
}
