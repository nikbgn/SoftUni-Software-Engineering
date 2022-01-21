using System;
using System.IO;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";
            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                
                int linecount = 1;
                using (var writer = new StreamWriter(outputFilePath))
                {
                    var line = reader.ReadLine();
                    while(line != null)
                    {
                        writer.WriteLine($"{linecount}. {line}");
                        linecount++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}