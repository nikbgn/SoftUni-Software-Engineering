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
            Console.WriteLine(DeleteProjectById(context));
        }
        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var toDelete = context
                .Projects
                .Where(p => p.ProjectId == 2)
                .First();

            var employeesProjects = context
                .EmployeesProjects
                .Where(p => p.ProjectId == 2);

            foreach (var project in employeesProjects)
            {
                context.EmployeesProjects.Remove(project);
            }

            context.Projects.Remove(toDelete);
            context.SaveChanges();

            var projects = context
                .Projects
                .Select(p => p.Name)
                .Take(10)
                .ToArray();

            foreach (var proj in projects)
            {
                sb.AppendLine(proj);
            }


            return sb.ToString().TrimEnd();
        }
    }
}
