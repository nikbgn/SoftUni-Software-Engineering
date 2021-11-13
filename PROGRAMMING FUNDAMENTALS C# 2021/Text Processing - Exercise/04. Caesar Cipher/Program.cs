using System;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = Console.ReadLine();
            for (int i = 0; i < test.Length; i++)
            {
                Console.Write((char)(test[i]+3));
            }
        }
    }
}
