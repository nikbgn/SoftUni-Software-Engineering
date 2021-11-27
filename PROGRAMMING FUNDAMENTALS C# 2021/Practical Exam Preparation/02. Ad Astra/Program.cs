using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(#|\|)(?<foodName>[A-Za-z ]+)\1(?<bestUntil>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<Calories>\d+)\1";
            int dailyCalories = 2000;
            int foodTotalCals = 0;
            StringBuilder output = new StringBuilder();
            MatchCollection matches = Regex.Matches(input,pattern);
            foreach (Match matchedFood in matches)
            {
                string foodName = matchedFood.Groups["foodName"].Value;
                string foodDate = matchedFood.Groups["bestUntil"].Value;
                string foodCalories = matchedFood.Groups["Calories"].Value;
                output.AppendLine($"Item: {foodName}, Best before: {foodDate}, Nutrition: {foodCalories}");
                foodTotalCals += int.Parse(foodCalories);
            }

            output.Insert(0, $"You have food to last you for: {foodTotalCals / dailyCalories} days!\n");
            Console.WriteLine(output);
        }
    }
}
