using System;
using System.Text;

namespace _01._Extract_Person_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder finalResult = new StringBuilder();
            int numOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfPeople; i++)
            {
                string lineWithInfo = Console.ReadLine();
                nameAgeExtractor(finalResult,lineWithInfo);
            }

            Console.WriteLine(finalResult);
            

        }

        private static void nameAgeExtractor(StringBuilder finalResult, string lineWithInfo)
        {
            
            int nameExtractIndexStart = lineWithInfo.IndexOf('@') + 1;
            int nameExtractIndexEnd = lineWithInfo.IndexOf('|');

            int ageExtractIndexStart = lineWithInfo.IndexOf('#') + 1;
            int ageExtractIndexEnd = lineWithInfo.IndexOf('*');

            string exctractedName = lineWithInfo[nameExtractIndexStart..nameExtractIndexEnd];
            string exctractedAge = lineWithInfo[ageExtractIndexStart..ageExtractIndexEnd];

            finalResult.AppendLine($"{exctractedName} is {exctractedAge} years old.");
        }
    }
}
