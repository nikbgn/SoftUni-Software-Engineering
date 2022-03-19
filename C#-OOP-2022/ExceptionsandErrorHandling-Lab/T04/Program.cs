using System;

namespace T04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputToVerify = Console.ReadLine().Split();
            foreach (var input in inputToVerify)
            {
                try
                {
                    IntSummator.TrySumInt(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{input}' processed - current sum: {IntSummator.TotalSum}");
                }

            }
            Console.WriteLine($"The total sum of all integers is: {IntSummator.TotalSum}");
        }


        public static class IntSummator
        {
            private static long totalSum;

            public static long TotalSum { get { return totalSum; } }

            public static void TrySumInt(string input)
            {
                if (!long.TryParse(input, out long _)) throw new FormatException($"The element '{input}' is in wrong format!");

                long number = long.Parse(input);
                if (number < int.MinValue || number > int.MaxValue) throw new OverflowException($"The element '{number}' is out of range!");
                totalSum += number;
            }

        }
    }
}
