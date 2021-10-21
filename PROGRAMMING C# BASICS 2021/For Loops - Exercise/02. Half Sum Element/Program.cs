using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int numRead = int.Parse(Console.ReadLine());
                sum += numRead;
                //Find max num
                if (numRead > max)
                {
                    max = numRead;
                }

            }
            //Take out max , to get the sum of the rest of the numbers.
            sum -= max;

            if (sum == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum-max)}");
            }
            
        }
    }
}
