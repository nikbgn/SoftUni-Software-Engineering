using System;
using System.Text;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMsg = Console.ReadLine();
            string[] command = Console.ReadLine().Split('|');
            StringBuilder sb = new StringBuilder(encryptedMsg);
            while (command[0] != "Decode")
            {
                switch (command[0])
                {
                    case "Move":
                        int numOfLetters = int.Parse(command[1]);
                        letterMover(sb, numOfLetters);
                        break;
                    case "Insert":
                        int indexToInsertAt = int.Parse(command[1]);
                        string valueToInsert = command[2];
                        sb.Insert(indexToInsertAt, valueToInsert);
                        break;
                    case "ChangeAll":
                        string substringToReplace = command[1];
                        string replaceWith = command[2];
                        sb.Replace(substringToReplace, replaceWith);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine().Split('|');
            }

            Console.WriteLine($"The decrypted message is: {sb}");
        }

        private static void letterMover(StringBuilder sb, int numOfLetters)
        {
            for (int i = 0; i < numOfLetters; i++)
            {
                char toMove = sb[0];
                sb.Append(toMove);
                sb.Remove(0, 1);
            }

        }
    }
}
