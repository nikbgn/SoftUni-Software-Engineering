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
            Console.WriteLine(GetLatestProjects(context));
        }
        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var lastestProjects = context
                .Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .Select(p => new
                {
                    ProjectName = p.Name,
                    ProjectDescription = p.Description,
                    ProjectStartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt")
                })
                .OrderBy(p => p.ProjectName)
                .ToArray();

            foreach (var project in lastestProjects)
            {
                sb.AppendLine(project.ProjectName);
                sb.AppendLine(project.ProjectDescription);
                sb.AppendLine(project.ProjectStartDate);
            }


            return sb.ToString().TrimEnd();
        }
    }
}
