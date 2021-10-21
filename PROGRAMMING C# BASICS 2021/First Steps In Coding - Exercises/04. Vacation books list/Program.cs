using System;

namespace _04._Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход
            //1. Брой страници - цяло число
            //2. Страници за час - реално число
            //3. Брой на дните - цяло число
            //Изход
            //Броят часове отделени за четене всеки ден

            int pagesCount = int.Parse(Console.ReadLine());
            double pagesPerHour = double.Parse(Console.ReadLine());
            int daysToRead = int.Parse(Console.ReadLine());

            double totalTimePerBook = pagesCount / pagesPerHour;

            double result = totalTimePerBook / daysToRead;
            Console.WriteLine(result);

        }
    }
}
