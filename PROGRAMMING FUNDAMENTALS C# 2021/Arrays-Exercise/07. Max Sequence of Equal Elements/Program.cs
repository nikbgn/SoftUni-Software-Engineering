using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bestSequence = 0;
            int currSequence = 0;
            string result = string.Empty;

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    currSequence += 1;
                    if (currSequence > bestSequence)
                    {
                        bestSequence = currSequence;
                        result = nums[i].ToString();
                    }
                }
                else
                {
                    currSequence = 0;
                }
            }

            for (int i = 0; i <= bestSequence; i++)
            {
                Console.Write(result + " ");
            }

        }
    }
}
