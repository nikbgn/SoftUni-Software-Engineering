using System;
using System.Text;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder output = new StringBuilder(Console.ReadLine());
            string[] command = Console.ReadLine().Split();
            while (command[0] != "Done")
            {
                string currCmd = command[0];

                switch (currCmd)
                {
                    case "TakeOdd":
                        takeOdd(output);
                        Console.WriteLine(output);
                        break;
                    case "Cut":
                        int startIndexCut = int.Parse(command[1]);
                        int lenOfCut = int.Parse(command[2]);
                        output.Remove(startIndexCut, lenOfCut);
                        Console.WriteLine(output);
                        break;
                    case "Substitute":
                        string substituteSubstring = command[1];
                        string substituteWith = command[2];
                        if (output.ToString().Contains(substituteSubstring))
                        {
                            output.Replace(substituteSubstring, substituteWith);
                            Console.WriteLine(output);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                    default:
                        break;

                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {output}");
        }

        private static void takeOdd(StringBuilder output)
        {
            StringBuilder temp = new StringBuilder();
            for (int i = 0; i < output.Length; i++)
            {
                if (i % 2 != 0)
                {

                    temp.Append(output[i]);
                }
            }
            output.Clear();
            output.Append(temp);
        }
    }
}
