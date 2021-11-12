using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int finalSum = GetStringSum(input[0], input[1]);
            Console.WriteLine(finalSum);
        }

        private static int GetStringSum(string v1, string v2)
        {
            int sum = 0;
            int minLength = Math.Min(v1.Length,v2.Length);
            for (int i = 0; i < minLength; i++)
            {
                sum += v1[i] * v2[i];
            }
            string longestLengthString = v1;
            if (longestLengthString.Length < v2.Length)
            {
                longestLengthString = v2;
            }
            for (int i = minLength; i < longestLengthString.Length; i++)
            {
                sum += longestLengthString[i];
            }
            return sum;
        }
    }
}
