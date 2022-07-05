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
            Console.WriteLine(GetEmployee147(context));
        }
        public static string GetEmployee147(SoftUniContext context)
        {

            StringBuilder sb = new StringBuilder();


            var employee = context.Employees
                .Where(e => e.EmployeeId == 147)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.JobTitle,
                    Projects = e.EmployeesProjects
                        .Select(p => p.Project.Name)
                        .OrderBy(p => p)
                        .ToArray()
                })
                .FirstOrDefault();

            sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            foreach (var project in employee.Projects)
            {
                sb.AppendLine(project);
            }





            return sb.ToString().TrimEnd();
        }
    }
}
