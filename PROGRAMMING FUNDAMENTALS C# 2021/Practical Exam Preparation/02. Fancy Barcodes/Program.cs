using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfBarcodes = int.Parse(Console.ReadLine());
            for (int i = 0; i < countOfBarcodes; i++)
            {
                string input = Console.ReadLine();
                string regex = @"@#+(?<barcode>[A-Z]+[A-Za-z0-9]+[A-Z]+)@#+";
                MatchCollection matches = Regex.Matches(input, regex);
                if (matches.Count > 0)
                {
                    foreach (Match match in matches)
                    {
                        if (match.Groups["barcode"].Value.Length > 5)
                        {
                            groupDecide(match.Groups["barcode"].Value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid barcode");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }

        private static void groupDecide(string value)
        {

            string group = string.Empty;
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    group += value[i];
                }
            }
            if (group.Length > 0) Console.WriteLine($"Product group: {group}");
            else Console.WriteLine("Product group: 00");


        }
    }
}
