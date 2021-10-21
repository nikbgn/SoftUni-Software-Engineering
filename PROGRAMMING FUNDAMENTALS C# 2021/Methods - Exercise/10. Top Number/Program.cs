using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            topNumberSolution(num);
        }



        static bool sumOfDigitsIsDivisibleBy8(int num)
        {
            int sum = 0;
            int temp = num.ToString().Length;
            for (int i = 0; i < temp; i++)
            {
                sum += num % 10;
                num /= 10;
            }

            if (sum % 8 == 0) { return true; }
            return false;
        }

        static bool containsOddDigit(int num)
        {
            int currDigit = 0;
            int temp = num.ToString().Length;
            for (int i = 0; i < temp; i++)
            {
                currDigit = num % 10;
                num /= 10;
                if (currDigit % 2 != 0) { return true; }
            }
            return false;
        }


        static void topNumberSolution(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (sumOfDigitsIsDivisibleBy8(i) && containsOddDigit(i)) { Console.WriteLine(i); }
            }
        }
    }
}
