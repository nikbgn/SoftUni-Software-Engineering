using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string action = Console.ReadLine();
            while (action != "Party!")
            {
                string[] items = action.Split();
                string method = items[0];
                string operation = items[1];
                string value = items[2];

                if (method == "Double")
                {


                    List<string> doubleNames = names
                        .FindAll(GetPredicate(operation, value));
                    if (!doubleNames.Any())
                    {
                        action = Console.ReadLine();
                        continue;
                    }
                    int index = names.
                        FindIndex(GetPredicate(operation, value));
                    names.InsertRange(index, doubleNames);

                }
                else
                {
                    names.RemoveAll(GetPredicate(operation, value));
                }

                action = Console.ReadLine();
            }
            if (names.Any())
            {

                Console.WriteLine(string.Join(", ", names) + " are going to the party!");
            }
            else Console.WriteLine("Nobody is going to the party!");
        }



        private static Predicate<string> GetPredicate(string operation, string value)
        {

            if (operation == "StartsWith")
            {
                return x => x.StartsWith(value);
            }
            if (operation == "EndsWith")
            {
                return x => x.EndsWith(value);
            }

            int valueAsInt = int.Parse(value);
            return x => x.Length == valueAsInt;
        }
    }
}
