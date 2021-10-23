using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Add":
                        int num = int.Parse(command[1]);
                        nums.Add(num);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        if (index < 0 || index >= nums.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.Insert(index, numToInsert);
                        }
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(command[1]);
                        if (indexToRemove < 0 || indexToRemove >= nums.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            nums.RemoveAt(indexToRemove);
                        }
                        break;
                    case "Shift":
                        string direction = command[1]; //Left or Right
                        int shifts = int.Parse(command[2]);
                        nums = shiftNums(nums, direction,shifts);
                        

                        break;
                }



                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ",nums));
        }

        private static List<int> shiftNums(List<int> nums, string direction, int shifts)
        {

            

            if (direction == "left")
            {
                for (int i = 0; i < shifts; i++)
                {
                    nums.Add(nums[0]);
                    nums.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < shifts; i++)
                {
                    nums.Insert(0, nums[nums.Count - 1]);
                    nums.RemoveAt(nums.Count-1);
                }
            }

            return nums;
        }
    }
}
