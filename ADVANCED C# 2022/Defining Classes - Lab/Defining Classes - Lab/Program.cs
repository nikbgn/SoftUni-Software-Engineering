using System;

namespace Defining_Classes___Lab
{
    class Program
    {


        class Test
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            Test a = new Test { Name = "asd" };
            Console.WriteLine(a.Name);
        }
    }
}
