using System;

namespace _01PROBLEM___SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            //Judge Points 100/100

            int employer1 = int.Parse(Console.ReadLine());
            int employer2 = int.Parse(Console.ReadLine());
            int employer3 = int.Parse(Console.ReadLine());
            int studentQuestionsCount = int.Parse(Console.ReadLine());


            int questionsPerHourAnswered = employer1 + employer2 + employer3;
            int hoursTaken = 0;

            while (true)
            {

                
                if (hoursTaken % 4 == 0)
                {
                    hoursTaken += 1;
                }
                else
                {
                    hoursTaken += 1;
                    studentQuestionsCount -= questionsPerHourAnswered;
                }

                if (studentQuestionsCount <= 0) { break; }


            }

            Console.WriteLine($"Time needed: {hoursTaken-1}h.");







        }
    }
}
