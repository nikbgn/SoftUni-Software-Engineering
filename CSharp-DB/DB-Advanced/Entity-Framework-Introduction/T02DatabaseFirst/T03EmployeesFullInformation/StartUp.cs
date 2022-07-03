namespace SoftUni
{
    using System;
    using System.Linq;
    using System.Text;
    using SoftUni.Data;
    public class StartUp
    {
        static void Main(string[] args)
        {
            var dbContext = new SoftUniContext();
            Console.WriteLine(GetEmployeesFullInformation(dbContext));
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {

            StringBuilder sb = new StringBuilder();
            var employees = context.Employees
                .OrderBy(e => e.EmployeeId)
                .Select(e => new
                {
                    e.FirstName,
                    e.LastName,
                    e.MiddleName,
                    e.JobTitle,
                    e.Salary
                })
                .ToArray();


            foreach (var e in employees)
            {
                sb.AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }

            return sb.ToString().TrimEnd();

        }

    }
}
