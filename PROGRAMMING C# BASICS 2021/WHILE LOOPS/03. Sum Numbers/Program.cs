using System;

namespace _03._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int target = firstNum;
            int sum = 0;
            while (true)
            {
                if (sum >= target)
                {
                    break;
                }
                
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }

            Console.WriteLine(sum);


        }
    }
}
