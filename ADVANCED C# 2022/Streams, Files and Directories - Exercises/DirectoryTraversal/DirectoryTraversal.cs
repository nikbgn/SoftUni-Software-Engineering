namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";


            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath,"*");
            var fileInfo = new Dictionary<string, Dictionary<string, double>>();

            foreach (var filePath in files)
            {
                string fileName = Path.GetFileName(filePath);
                string extension = Path.GetExtension(filePath);
                double size = new FileInfo(filePath).Length / 1024.0;
                if (!fileInfo.ContainsKey(extension))
                {
                    fileInfo.Add(extension,new Dictionary<string, double>());

                }
                fileInfo[extension].Add(fileName, size);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var item in fileInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(item.Key);
                foreach (var file in item.Value.OrderBy(x => x.Value))
                {
                    sb.AppendLine($"--{file.Key} - {file.Value:f3}kb");
                }
            }
            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt", textContent);
        }

    }
}
