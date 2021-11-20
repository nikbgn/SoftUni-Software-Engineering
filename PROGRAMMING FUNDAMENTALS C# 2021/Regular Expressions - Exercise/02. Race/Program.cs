using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfRunners = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> ranking = new Dictionary<string, int>();

            string input = Console.ReadLine();
            string regexNames = @"(?<name>[A-Za-z]+)";
            string regexDistance = @"(?<distanceRan>\d)";
            StringBuilder sb = new StringBuilder();


            while (input != "end of race") 
            {
                int distanceRan = Regex.Matches(input, regexDistance)
                    .Cast<Match>()
                    .Select(v => int.Parse(v.Groups["distanceRan"].Value))
                    .Sum();
                MatchCollection matchesNames = Regex.Matches(input, regexNames);

                foreach (Match item in matchesNames)
                {
                    sb.Append(item.Groups["name"].Value);
                }
                if (listOfRunners.Contains(sb.ToString()))
                {
                    rankingUpdater(ranking, sb.ToString(), distanceRan);
                }
                sb.Clear();
                input = Console.ReadLine();
            }

            List<string> winners = new List<string>();
            foreach (var item in ranking.OrderByDescending(x => x.Value))
            {
                winners.Add(item.Key);
                
            }

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");




        }

        private static void rankingUpdater(Dictionary<string, int> ranking, string name, int distanceRan)
        {
            if (!ranking.ContainsKey(name))
            {
                ranking.Add(name, distanceRan);
            }
            else
            {
                ranking[name] += distanceRan;
            }
        }

    }
}
