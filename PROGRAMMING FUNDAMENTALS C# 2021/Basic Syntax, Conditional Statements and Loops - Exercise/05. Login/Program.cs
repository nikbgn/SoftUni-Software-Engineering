using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = "";
            for (int i = user.Length - 1; i >= 0; i++)
            {
                password += user[i];
            }

            int tries = 0;
            while (tries < 4)
            {
                string userInput = Console.ReadLine();
                tries += 1;
                if (userInput == password) { Console.WriteLine($"User {user} logged in."); break; }
                
                if (tries == 4) { Console.WriteLine($"User {user} blocked!");break; }
                Console.WriteLine("Incorrect password. Try again.");

            }


        }
    }
}
