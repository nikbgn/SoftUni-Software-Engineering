using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var companiesInfo = new Dictionary<string, List<string>>(); //Company name, employees ids
            string[] command = Console.ReadLine().Split(" -> ");

            while (command[0] != "End")
            {
                string currCompanyName = command[0];
                string currEmployeeID = command[1];

                if (!companiesInfo.ContainsKey(currCompanyName))
                {
                    companiesInfo.Add(currCompanyName,new List<string>() { currEmployeeID });
                }
                else
                {
                    if (companiesInfo[currCompanyName].Contains(currEmployeeID)) 
                    {
                        //We can't have 2 employees with the same ID, but the exercise problem doesn't tell me to throw an error, so I have to just do nothing about it lol
                    }
                    else { companiesInfo[currCompanyName].Add(currEmployeeID); }
                }

                command = Console.ReadLine().Split(" -> ");
            }


            foreach (var company in companiesInfo.OrderBy(nameOfCompany => nameOfCompany.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }


        }
    }
}
