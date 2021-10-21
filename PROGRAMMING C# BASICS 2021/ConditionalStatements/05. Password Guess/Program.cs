using System;

namespace _05._Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "s3cr3t!P@ssw0rd";
            string userInput = Console.ReadLine();
            if (userInput == password)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
