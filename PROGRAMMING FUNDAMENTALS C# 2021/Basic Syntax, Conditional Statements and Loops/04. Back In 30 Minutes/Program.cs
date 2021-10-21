using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Every time Stamat tries to pay the bills he sees on the cash desk the sign: "I will be back in 30 minutes".One day Stamat was tired of waiting and decided he needs a program, which prints the time after 30 minutes, so could come back after exactly 30 minutes.He is not able to write the program by himself, so he asks for help.
            //Input
            //Two numbers are read from the console:
            //⦁	The first number is hours and will be between 0 and 23.
            //⦁	The second number is minutes and will be between 0 and 59.
            //Output
            //Print on the console the time after 30 minutes.The result should be in format hh:mm.The hours may contain one or two numbers and the minutes always have two numbers(with leading zero).

            int hour = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 30;
            if (mins >= 60)
            {

                hour += 1;
                mins -= 60;
            }
            if (hour >= 24)
            {
                hour = 0;
            }

            Console.WriteLine($"{hour}:{mins:d2}");
        }
    }
}
