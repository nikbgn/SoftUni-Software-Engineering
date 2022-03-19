using System;
using System.Collections.Generic;

namespace T02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            
            while (numbers.Count < 10)
            {
                try
                {
                    int tryNum = ReadNumber(1, 100, numbers);
                    numbers.Add(tryNum);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(String.Join(", ",numbers));

        }

        public static int ReadNumber(int start, int end, List<int> numbers)
        {
            //such that 1 < a1 < … < a10 < 100
            string input = Console.ReadLine();

            if(!int.TryParse(input, out _))
            {
                throw new FormatException("Invalid Number!");
            }

            int number = int.Parse(input);

            if (numbers.Count > 0 && number <= numbers[numbers.Count - 1]) throw new ArgumentException($"Your number is not in range {numbers[numbers.Count - 1]} - 100!");
            if (number <= start || number >= end) throw new ArgumentException($"Your number is not in range {start} - 100!");
            return number;
        }
    }
}
