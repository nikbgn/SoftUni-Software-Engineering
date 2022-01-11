using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"%(?<customer>[A-Z][a-z]+)%[^$|%.]*<(?<product>\w+)>[^$|%\.]*\|(?<qty>\d+)\|[^$|%\.]*(?<price>\d+\.\d+|\d)\$";

            double totalIncome = 0;
            StringBuilder output = new StringBuilder();
            while (input != "end of shift")
            {
                MatchCollection matches = Regex.Matches(input, regex,RegexOptions.ExplicitCapture);
                bool validation = matches.Count == 1 ? true : false;
                if (validation)
                {
                    foreach (Match match in matches)
                    {
                        double price = int.Parse(match.Groups["qty"].Value) * double.Parse(match.Groups["price"].Value);
                        output.AppendLine($"{match.Groups["customer"].Value}:{match.Groups["product"].Value}-{price:f2}");
                        totalIncome += price;
                    }

                }


                input = Console.ReadLine();
            }
            output.AppendLine($"Total income: {totalIncome:f2}");
            Console.WriteLine(output);





        }
    }
}
