using System;
using System.Linq;

namespace _02PROBLEM___Array_Modifier
{
    class Program
    {
        //Judge Points 100/100

        static void Main(string[] args)
        {
            int[] arrayOfInts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] commandTaken = Console.ReadLine().Split();

            while (commandTaken[0] != "end")
            {


                switch (commandTaken[0])
                {
                    case "swap":
                        int index1 = int.Parse(commandTaken[1]);
                        int index2 = int.Parse(commandTaken[2]);
                        int swapNum = arrayOfInts[index1];
                        arrayOfInts[index1] = arrayOfInts[index2];
                        arrayOfInts[index2] = swapNum;
                        
                        break;
                    case "multiply":
                        int n1 = int.Parse(commandTaken[1]);
                        int n2 = int.Parse(commandTaken[2]);
                        arrayOfInts[n1] = arrayOfInts[n1] * arrayOfInts[n2];
                        break;
                    case "decrease":
                        for (int i = 0; i < arrayOfInts.Length; i++)
                        {
                            arrayOfInts[i] -= 1;
                        }
                        break;
                    default:
                        break;


                }
                commandTaken = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ",arrayOfInts));
        }
    }
}
