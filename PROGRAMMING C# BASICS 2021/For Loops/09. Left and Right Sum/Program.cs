using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());  //2
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {

                leftSum = leftSum + int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {

                rightSum = rightSum + int.Parse(Console.ReadLine());
            }

            if (rightSum == leftSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
            }
        }
    }
}
