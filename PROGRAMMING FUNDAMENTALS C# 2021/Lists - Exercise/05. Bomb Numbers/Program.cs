using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> bombInfo = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = bombInfo[0];
            int bombPower = bombInfo[1];

            nums = detonateBombs(nums, bomb, bombPower);


            Console.WriteLine(nums.Sum());


        }

        private static List<int> detonateBombs(List<int> nums, int bomb, int bombPower)
        {

            for (int i = 0; i < nums.Count; i++)
            {
                //Find bomb
                if (nums[i] == bomb)
                {
                    for (int j = 0; j < bombPower; j++)
                    {
                        int leftIndex = i - 1;
                        //Minimum requirement
                        if (leftIndex == 0)
                        {
                            nums.RemoveAt(leftIndex);
                            i = i - 1;
                            break;
                        }
                        //Stop the cycle if we go outside of boundry
                        else if (leftIndex < 0)
                        {
                            break;
                        }
                        else
                        {
                            nums.RemoveAt(leftIndex);
                            i = i - 1;
                        }
                    }

                    for (int j = 0; j < bombPower; j++)
                    {
                        int rightIndex = i + 1;
                        //MAX
                        if (rightIndex == nums.Count - 1)
                        {
                            nums.RemoveAt(rightIndex);
                            break;
                        }
                        //If we go outside of boundry break
                        else if (rightIndex > nums.Count - 1)
                        {
                            break;
                        }
                        else
                        {
                            nums.RemoveAt(rightIndex);
                        }
                    }

                    nums.Remove(bomb);
                    i = -1;
                }
            }


            return nums;
        }
    }
}
