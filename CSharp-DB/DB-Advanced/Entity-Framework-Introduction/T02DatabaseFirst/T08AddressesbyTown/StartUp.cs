namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;
    using SoftUni.Data;
    using SoftUni.Models;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            Console.WriteLine(GetAddressesByTown(context));
        }

        public static string GetAddressesByTown(SoftUniContext context)
        {

            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses
                .OrderByDescending(a => a.Employees.Count)
                .ThenBy(a => a.Town.Name)
                .ThenBy(a => a.AddressText)
                .Select(a => new
                {
                    a.Employees,
                    TownName = a.Town.Name,
                    a.AddressText
                })
                .Take(10)
                .ToArray();


            foreach (var item in addresses)
            {
                sb.AppendLine($"{item.AddressText}, {item.TownName} - {item.Employees.Count} employees");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
