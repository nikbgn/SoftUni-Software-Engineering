using System;

namespace _01.ActionPrint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> NamePrinter = (x) => Console.WriteLine(x);
            string[] arr = Console.ReadLine().Split();
            foreach (var item in arr)
            {
                NamePrinter(item);
            }
        }
    }
}
