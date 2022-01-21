using System;
using System.IO;


namespace OddLines { 
public class OddLines
{
    static void Main()
    {
        string inputFilePath = @"..\..\..\input.txt";
        string outputFilePath = @"..\..\..\output.txt";
        ExtractOddLines(inputFilePath, outputFilePath);
    }
    public static void ExtractOddLines(string inputFilePath, string outputFilePath)
    {
        var reader = new StreamReader(inputFilePath);
        int index = 0;
        using (reader)
        {

            string line = reader.ReadLine();
            using (var writer = new StreamWriter(outputFilePath))
            {
                while (line != null)
                {
                    index++;
                    if (index % 2 == 1)
                    {
                        writer.WriteLine(line);
                    }
                    line = reader.ReadLine();
                }
            }

        }
    }
}

}

