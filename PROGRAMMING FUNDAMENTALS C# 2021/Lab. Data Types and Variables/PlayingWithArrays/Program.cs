using System;

namespace PlayingWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" ,"Sunday"};


            int input = int.Parse(Console.ReadLine());
            if (input > 7 || input < 1) { Console.WriteLine("Invalid day!"); }
            else { Console.WriteLine(dayWeek[input-1]); }
        }
    }
}
