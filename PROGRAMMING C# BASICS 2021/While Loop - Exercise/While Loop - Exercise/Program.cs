using System;

namespace While_Loop___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stop 1: when the book we are seraching for is found. (book==takenBook)
            //Stop 2: when all books in the libary are checked but there are no matches :)
            string searchedBook = Console.ReadLine();
            string takenBook = Console.ReadLine();
            int countBooks = 0;

            while (takenBook != "No More Books")
            {
                
                if (takenBook == searchedBook)
                {
                    Console.WriteLine($"You checked {countBooks} books and found it.");
                    break;
                }
                else
                {
                    countBooks++;
                }
                takenBook = Console.ReadLine();


            }

            if (takenBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {countBooks} books.");
            }
        }
    }
}
