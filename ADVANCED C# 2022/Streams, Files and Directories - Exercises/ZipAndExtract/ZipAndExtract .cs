namespace ZipAndExtract
{
    using System;
    using System.IO;
    using System.IO.Compression;

    public class ZipAndExtract
    {
        static void Main(string[] args)
        {
            string inputFile = @"..\..\..\copyMe.png";
            string zipArchiveFile = @"..\..\..\archive.zip";
            string extractedFile = @"..\..\..\extracted.png";
            ZipFileToArchive(inputFile, zipArchiveFile);

            var fileNameOnly = Path.GetFileName(inputFile);
            ExtractFileFromArchive(zipArchiveFile, fileNameOnly, extractedFile);
        }

        public static void ZipFileToArchive(string inputFilePath, string zipArchiveFilePath)
        {
            var name = Path.GetFileName(inputFilePath);
            var zip = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Create);
            zip.CreateEntryFromFile(inputFilePath, name);
            zip.Dispose();
        }

        public static void ExtractFileFromArchive(string zipArchiveFilePath, string fileName, string outputFilePath)
        {
            var zipExtractor = ZipFile.Open(zipArchiveFilePath, ZipArchiveMode.Read);
            var file = zipExtractor.GetEntry(fileName);
            file.ExtractToFile(outputFilePath);
            
        }
    }
}
