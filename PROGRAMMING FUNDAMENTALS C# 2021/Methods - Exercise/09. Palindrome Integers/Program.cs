using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    return;
                }
                else
                {
                    int number = int.Parse(command);
                    Console.WriteLine(checkForPalindromeInteger(number)); 
                }
            }

        }

        static bool checkForPalindromeInteger(int number)
        {
            if (numReverse(number) == number) { return true; }
            return false;
        }


        static int numReverse(int n)
        {

            string temp = n.ToString();
            string reverseNumber = string.Empty;

            for (int i = temp.Length - 1; i >= 0; i--)
            {
                reverseNumber += temp[i];
            }

            return int.Parse(reverseNumber);

        }
    }
}
