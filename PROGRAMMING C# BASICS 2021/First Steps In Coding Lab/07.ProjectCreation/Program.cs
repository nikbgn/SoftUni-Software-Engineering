using System;

namespace _07.ProjectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArhitect = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());
            int timePerProject = 3;
            int timeAll = numberOfProjects * timePerProject;
            Console.WriteLine($"The architect {nameOfArhitect} will need {timeAll} hours to complete {numberOfProjects} project/s.");
        }
    }
}
