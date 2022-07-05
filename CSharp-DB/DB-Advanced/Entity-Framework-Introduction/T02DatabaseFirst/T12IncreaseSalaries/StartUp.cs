namespace SoftUni
{
    using SoftUni.Data;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        static void Main(string[] args)
        {
            var context = new SoftUniContext();
            Console.WriteLine(IncreaseSalaries(context));
        }
        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context
                .Employees
                .Where(
                    e => e.Department.Name == "Engineering" ||
                         e.Department.Name == "Tool Design" ||
                         e.Department.Name == "Marketing" ||
                         e.Department.Name == "Information Services");

            foreach (var emp in employees)
            {
                emp.Salary += emp.Salary * 0.12M;
            }

            context.SaveChanges();

            var employeesUpdated = context
                .Employees
                .Where(
                    e => e.Department.Name == "Engineering" ||
                         e.Department.Name == "Tool Design" ||
                         e.Department.Name == "Marketing" ||
                         e.Department.Name == "Information Services")
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.Salary
                })
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray();


            foreach (var emp in employeesUpdated)
            {
                sb.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
            }



            return sb.ToString().TrimEnd();
        }
    }
}
