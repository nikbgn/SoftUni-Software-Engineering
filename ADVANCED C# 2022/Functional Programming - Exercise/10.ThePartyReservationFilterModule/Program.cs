using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.ThePartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split().ToList();
            string action = Console.ReadLine();
            var allFilters = new Dictionary<string, Predicate<string>>();


            while (action != "Print")
            {
                string[] items = action.Split(';');
                string method = items[0];
                string operation = items[1];
                string value = items[2];


                if(method == "Add filter")
                {
                    allFilters.Add(operation + value,GetPredicate(operation,value));
                }
                else
                {
                    allFilters.Remove(operation + value);
                }


                action = Console.ReadLine();
            }

            foreach (var (key,value) in allFilters)
            {
                names.RemoveAll(value);
            }
            Console.WriteLine(String.Join(" ",names));
        }
        private static Predicate<string> GetPredicate(string operation, string value)
        {

            if (operation == "Starts with")
            {
                return x => x.StartsWith(value);
            }
            if (operation == "Ends with")
            {
                return x => x.EndsWith(value);
            }
            if (operation == "Contains")
            {
                return x => x.Contains(value);
            }
            int valueAsInt = int.Parse(value);
            return x => x.Length == valueAsInt;



        }


    }

}
