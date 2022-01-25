using System.IO;

namespace CopyBinaryFile
{
    public class CopyBinaryFile
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\copyMe.png";
            string outputPath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputPath, outputPath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using FileStream fileStreamReader = new FileStream(inputFilePath, FileMode.Open);
            using FileStream fileStreamWriter = new FileStream(outputFilePath, FileMode.Create);


            byte[] bytes = new byte[10000];

            while (true)
            {
                int currentBytes = fileStreamReader.Read(bytes, 0, bytes.Length);
                if (currentBytes == 0) break;
            }

            fileStreamWriter.Write(bytes, 0, bytes.Length);
        }
    }
}
