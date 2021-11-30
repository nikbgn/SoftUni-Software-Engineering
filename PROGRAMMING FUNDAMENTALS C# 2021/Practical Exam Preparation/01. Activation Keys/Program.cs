using System;
using System.Text;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            StringBuilder sb = new StringBuilder(rawKey);
            string[] command = Console.ReadLine().Split(">>>");
            while (command[0] != "Generate")
            {
                string currentCommand = command[0];
                switch (currentCommand)
                {
                    case "Contains":
                        string substring = command[1];
                        if (sb.ToString().Contains(substring)) Console.WriteLine($"{sb} contains {substring}");
                        else Console.WriteLine("Substring not found!");
                        break;
                    case "Flip":
                        string flipTo = command[1]; //Can contain Upper or Lower
                        int startIndex = int.Parse(command[2]);
                        int endIndex = int.Parse(command[3]);
                        int len = Math.Abs(endIndex - startIndex);
                        if (flipTo == "Upper")
                        {
                            sb.Replace(sb.ToString().Substring(startIndex, len), sb.ToString().Substring(startIndex, len).ToUpper());
                            Console.WriteLine(sb);
                        }
                        else
                        {
                            sb.Replace(sb.ToString().Substring(startIndex, len), sb.ToString().Substring(startIndex, len).ToLower());
                            Console.WriteLine(sb);
                        }

                        break;
                    case "Slice":
                        int startSlice = int.Parse(command[1]);
                        int endSlice = int.Parse(command[2]);
                        int lenSlice = Math.Abs(endSlice - startSlice);
                        sb.Remove(startSlice, lenSlice);
                        Console.WriteLine(sb);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
