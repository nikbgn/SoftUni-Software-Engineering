using System;
using System.Collections.Generic;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            var parkingValidationService = new Dictionary<string, string>();

            int numberOfCarsToRegister = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCarsToRegister; i++)
            {
                string[] command = Console.ReadLine().Split();




                if (command[0] == "register")
                {
                    string username = command[1];
                    string licensePlateNumber = command[2];
                    if (!parkingValidationService.ContainsKey(username))
                    {
                        parkingValidationService[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {parkingValidationService[username]}");
                    }
                }

                else
                {
                    string username = command[1];
                    if (!parkingValidationService.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{ username } unregistered successfully");
                        parkingValidationService.Remove(username);
                    }
                }

            }
            foreach (var registration in parkingValidationService)
            {
                Console.WriteLine($"{registration.Key} => {registration.Value}");
            }


        }
    }
}
