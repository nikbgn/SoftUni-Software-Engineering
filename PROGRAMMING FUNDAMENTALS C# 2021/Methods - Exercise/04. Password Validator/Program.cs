using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool passValidLength = ValidatePassLength(password);
            bool passValidSymbols = ValidatePassText(password);
            bool passMoreThanTwoDigits = ValidatePassDigit(password);

            if (!passValidLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!passValidSymbols)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!passMoreThanTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (passMoreThanTwoDigits && passValidLength && passValidSymbols)
            {
                Console.WriteLine("Password is valid");
            }
            
        }



        static bool ValidatePassLength(string text)
        {
            return text.Length >= 6 && text.Length <= 10;
        }

        static bool ValidatePassText(string text)
        {

            foreach (char character in text)
            {
                
                if (char.IsLetterOrDigit(character) == false)
                {
                    return false;
                }
            }
            return true;
        }

        static bool ValidatePassDigit(string text)
        {
            int countOfDigits = 0;
            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    countOfDigits++;
                }
            }
            return countOfDigits >= 2;
        }
    }
}
