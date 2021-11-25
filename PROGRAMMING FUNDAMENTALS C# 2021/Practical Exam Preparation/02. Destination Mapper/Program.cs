using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string locations = Console.ReadLine();
            string regex = @"(?<sep>\/|=)(?<place>[A-Z][A-za-z]{2,})\k<sep>";
            int travelPoints = 0;
            StringBuilder result = new StringBuilder();
            MatchCollection matches = Regex.Matches(locations, regex);

            var destinations = matches
                .Cast<Match>()
                .Select(x => x.Groups["place"].Value.Trim())
                .ToArray();

            foreach (var item in destinations)
            {
                
                travelPoints += item.Length;

            }

            result.Append($"Destinations: {string.Join(", ", destinations)}\n");
            result.Append($"Travel Points: {travelPoints}");
            Console.WriteLine(result);


        }
    }
}
