using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] copyList = intList.ToArray();
            string[] command = Console.ReadLine().Split();

            string cmd = string.Empty;


            while (true)
            {

                

                if (command[0] == "end")
                {
                    if (!compareLists(intList, copyList)) {Console.WriteLine(string.Join(" ",intList)); }
                    return;
                }

                cmd = command[0];

                switch (cmd)
                {
                    case "Add":
                        int numToAdd = int.Parse(command[1]);
                        intList.Add(numToAdd);
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(command[1]);
                        intList.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(command[1]);
                        intList.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int item = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        intList.Insert(index, item);
                        break;
                    case "Contains":
                        int numToCheck = int.Parse(command[1]);
                        Console.WriteLine(intList.Contains(numToCheck)?"Yes":"No such number"); 
                        break;
                    case "PrintEven":
                        printEvenNums(intList);
                        break;
                    case "PrintOdd":
                        printOddNums(intList);
                        break;
                    case "GetSum":
                        Console.WriteLine(intList.Sum());
                        break;
                    case "Filter":
                        string condition = command[1];
                        int number = int.Parse(command[2]);
                        filter(condition,number,intList);
                        break;
                    default:
                        break;
                }


                command = Console.ReadLine().Split();

            }
        }

        private static void filter(string condition, int number, List<int> intList)
        {
            List<int> filteredNums = new List<int>() { };
            switch (condition)
            {
                case ">":
                    foreach (int num in intList)
                    {
                        if (num > number) { filteredNums.Add(num); }
                    }
                    break;
                case "<":
                    foreach (int num in intList)
                    {
                        if (num < number) { filteredNums.Add(num); }
                    }
                    break;
                case ">=":
                    foreach (int num in intList)
                    {
                        if (num >= number) { filteredNums.Add(num); }
                    }
                    break;
                case "<=":
                    foreach (int num in intList)
                    {
                        if (num <= number) { filteredNums.Add(num); }
                    }
                    break;
                default:
                    break;
            }

            Console.WriteLine(string.Join(" ",filteredNums));
        }

        private static void printOddNums(List<int> intList)
        {
            List<int> evenInts = new List<int>() { };
            foreach (int item in intList)
            {
                if (item % 2 != 0) { evenInts.Add(item); }
            }

            Console.WriteLine(string.Join(" ", evenInts));
        }

        private static void printEvenNums(List<int> intList)
        {
            List<int> evenInts = new List<int>() { };
            foreach (int item in intList)
            {
                if (item % 2 == 0) { evenInts.Add(item); }
            }

            Console.WriteLine(string.Join(" ",evenInts));
        }

        private static bool compareLists(List<int> intList, int[] copyList)
        {
            bool sameLists = true;
            if(intList.Count != copyList.Length) { sameLists = false; return sameLists; }

            for (int i = 0; i < copyList.Length; i++)
            {
                if (intList[i] != copyList[i]) { sameLists = false; return sameLists; }
            }

            return true;
        }
    }
}
