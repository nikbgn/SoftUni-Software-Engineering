using System;
using System.Linq;

namespace Functional_Programming_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Playing around with Func
            Func<int, string> lambdaFunc = (age) => $"You are {age} yrs old.";
            Func<int,DateTime, string> agePrinter = GetAge;
            Console.WriteLine(agePrinter(19,DateTime.Now));
            Console.WriteLine(lambdaFunc(19));

            Action<string> helloSayer = x => Console.WriteLine($"sup {x}");
            helloSayer("hihi");
        }

        public static string GetAge(int age, DateTime date) => $"You age is: {age} Date: {date}";
    }
}
