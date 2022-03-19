using System;
using System.Collections.Generic;
using System.Linq;

namespace T05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionsCount = 0;
            while (exceptionsCount < 3)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "Replace":
                        try
                        {
                            VerifyVariablesAreInt(command[1], command[2]);
                            int givenIDX = int.Parse(command[1]);
                            int replaceWith = int.Parse(command[2]);
                            VerifyIndex(arrayOfNums, givenIDX);
                            arrayOfNums[givenIDX] = replaceWith;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            exceptionsCount++;
                        }
                        break;
                    case "Print":
                        try
                        {
                            VerifyVariablesAreInt(command[1], command[2]);
                            int startIDX = int.Parse(command[1]);
                            int endIDX = int.Parse(command[2]);
                            VerifyIndex(arrayOfNums, startIDX);
                            VerifyIndex(arrayOfNums, endIDX);
                            //Temp arr
                            List<int> temp = new List<int>();
                            //By constraints we are sure that startIDX is always <= endIDX
                            for (int i = startIDX; i <= endIDX; i++)
                            {
                                temp.Add(arrayOfNums[i]);
                            }
                            Console.WriteLine(String.Join(", ", temp));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            exceptionsCount++;
                        }
                        break;
                    case "Show":
                        try
                        {
                            VerifyVariablesAreInt(command[1]);
                            int idx = int.Parse(command[1]);
                            VerifyIndex(arrayOfNums, idx);
                            Console.WriteLine(arrayOfNums[idx]);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            exceptionsCount++;
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(String.Join(", ", arrayOfNums));
        }

        private static void VerifyIndex(int[] arrayOfNums, int givenIDX)
        {
            if (givenIDX < 0 || givenIDX >= arrayOfNums.Length) throw new Exception(ExceptionMessages.IndexDoesNotExistError);
        }

        private static void VerifyVariablesAreInt(params string[] vars)
        {
            foreach (var item in vars)
            {
                if (!int.TryParse(item, out int _))
                {
                    throw new Exception(ExceptionMessages.IncorrectFormatError);
                }
            }
        }
    }


    public static class ExceptionMessages
    {
        public static string IndexDoesNotExistError = "The index does not exist!";
        public static string IncorrectFormatError = "The variable is not in the correct format!";
    }

}
