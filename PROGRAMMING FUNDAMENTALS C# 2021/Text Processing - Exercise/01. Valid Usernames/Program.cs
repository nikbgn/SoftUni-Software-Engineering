using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            //sh, too_long_username, !lleg@l ch@rs, jeffbutt
            string[] userNames = Console.ReadLine().Split(", ");
            foreach (var userName in userNames)
            {
                if (userNameValidator(userName))
                {
                    Console.WriteLine(userName);
                }
            }
        }


        public static bool userNameValidator(string username)
        {

            bool lengthCheck = username.Length >= 3 && username.Length <= 16;
            bool containsIllegalChars = true;


            foreach (char character in username)
            {
                if (char.IsLetterOrDigit(character) || (character == '_' || character == '-'))
                {
                    containsIllegalChars = false;
                }
                else
                {
                    containsIllegalChars = true;
                    return false;
                }
            }


            if (lengthCheck) { return true; }
            

            return false;
        }
    }
}
