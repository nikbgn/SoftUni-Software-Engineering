using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            double gradeSum = 0;
            bool excluded = false;

            while (!excluded)
            {
                
                for (int i = 1; i <= 12; i++)
                {
                    double studentGrade = double.Parse(Console.ReadLine());
                    if (studentGrade < 4.00)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {i} grade");
                        excluded = true;
                        break;
                    }
                    else if (studentGrade >= 4.00)
                    {
                        gradeSum += studentGrade;
                    }
                }


                break;
                

            }
            if ((gradeSum / 12) >= 4 && (gradeSum / 12) <= 6.00 && !excluded)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {gradeSum / 12:f2}");
            }




        }
    }
}

