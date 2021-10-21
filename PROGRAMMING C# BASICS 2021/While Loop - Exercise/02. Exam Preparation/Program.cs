using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            // if command = "Enough" => print => avg. grade, num of problems, last problem, => break;
            // if allowedFails is met => print => you need a break {num of bad grades} => break;

            int allowedFails = int.Parse(Console.ReadLine());
            int failedGrades = 0;
            int solvedProblems = 0;
            double sumOfGrades = 0;
            string lastProblem = "";
            bool failed = true;


            while (failedGrades < allowedFails)
            {
                string problemName = Console.ReadLine();
                if (problemName == "Enough")
                {
                    failed = false;
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    failedGrades++;
                }

                sumOfGrades += grade;
                solvedProblems++;
                lastProblem = problemName;
            }

            if (failed)
            {
                Console.WriteLine($"You need a break, {failedGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sumOfGrades/solvedProblems:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }


        }
    }
}
