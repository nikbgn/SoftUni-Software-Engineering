using System;
using System.Collections.Generic;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> test = new List<int>() { 1, 2, 3 };

            test.ForEach(item => Console.WriteLine($"{item} item"));
        }
    }
}
