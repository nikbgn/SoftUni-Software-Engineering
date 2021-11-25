using System;
using System.Text;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();
            StringBuilder decryptedMSG = new StringBuilder(encryptedMessage);
            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] cmd = command.Split(":|:");
                string currCMD = cmd[0];
                switch (currCMD)
                {
                    case "InsertSpace":
                        int indexToInsertAt = int.Parse(cmd[1]);
                        decryptedMSG.Insert(indexToInsertAt, ' ');
                        Console.WriteLine(decryptedMSG);
                        break;
                    case "Reverse":
                        string subString = cmd[1];
                        string toAdd = string.Empty;
                        if (decryptedMSG.ToString().Contains(subString))
                        {
                            decryptedMSG.Remove(decryptedMSG.ToString().IndexOf(subString), subString.Length);
                            toAdd = reverseString(subString);
                            decryptedMSG.Append(toAdd);
                            Console.WriteLine(decryptedMSG);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string toChange = cmd[1];
                        string replacement = cmd[2];
                        decryptedMSG.Replace(toChange, replacement);
                        Console.WriteLine(decryptedMSG);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {decryptedMSG}");
        }

        private static string reverseString(string toAdd)
        {
            string reversedString = string.Empty;
            for (int i = toAdd.Length - 1; i >= 0; i--)
            {
                reversedString += toAdd[i];
            }

            return reversedString;
        }
    }
}
