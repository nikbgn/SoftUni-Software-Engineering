using System;

namespace _06._Salary
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int tab = 1; tab <=n; tab++)
            {
                string siteName = Console.ReadLine();
                switch (siteName)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }


                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }


            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }

            
        }
    }
}
