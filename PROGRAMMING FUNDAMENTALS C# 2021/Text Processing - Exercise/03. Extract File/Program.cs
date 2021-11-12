using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");
            Console.WriteLine($"File name: {path[path.Length-1].Split('.')[0]}\nFile extension: {path[path.Length - 1].Split('.')[1]}");
        }
    }
}
