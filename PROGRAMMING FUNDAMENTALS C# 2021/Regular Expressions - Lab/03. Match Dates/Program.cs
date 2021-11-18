using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b(?<day>\d{2})(?<sep>\/|-|.)(?<month>[A-Z][a-z]{2})\k<sep>(?<year>\d{4})\b";
            string dates = Console.ReadLine();
            MatchCollection matches = Regex.Matches(dates, regex);

            foreach (Match dateFound in matches)
            {
                var currDay = dateFound.Groups["day"].Value;
                var currMonth = dateFound.Groups["month"].Value;
                var currYear = dateFound.Groups["year"].Value;

                Console.WriteLine($"Day: {currDay}, Month: {currMonth}, Year: {currYear}");

            }

        }
    }
}
