namespace SoftUni
{
    using SoftUni.Data;
    using SoftUni.Models;
    using System.Linq;
    using System;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            Console.WriteLine( AddNewAddressToEmployee(context));
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(newAddress);

            var employeeNakov = context.Employees
                .FirstOrDefault(e => e.LastName == "Nakov"); //This employee DOES exist so it isn't really needed to use first or default...

            employeeNakov.Address = newAddress;

            context.SaveChanges();

            string[] employees = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToArray();


            foreach (var e in employees)
            {
                sb.AppendLine(e);
            }
            return sb.ToString().TrimEnd();


        }
    }
}
