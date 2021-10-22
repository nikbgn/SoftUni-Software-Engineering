using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            Console.WriteLine(String.Join(" ",mergeIntLists(list1,list2)));
        }



        static List<int> mergeIntLists(List<int> list1, List<int> list2)
        {
            List<int> returnList = new List<int>();

            if (list1.Count > list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    returnList.Add(list1[i]);
                    returnList.Add(list2[i]);
                }
                for (int i = list2.Count; i < list1.Count; i++)
                {

                    returnList.Add(list1[i]);
                }

            }
            else
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    returnList.Add(list1[i]);
                    returnList.Add(list2[i]);
                }
                for (int i = list1.Count; i < list2.Count; i++)
                {
                    returnList.Add(list2[i]);
                }

            }


            return returnList;
        }
    }
}