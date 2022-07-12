namespace BookShop
{
    using BookShop.Models.Enums;
    using Data;
    using Initializer;
    using System;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            
            using var db = new BookShopContext();
            //DbInitializer.ResetDatabase(db);
            int lengthCheck = int.Parse(Console.ReadLine());
            Console.WriteLine($"There are {CountBooks(db,lengthCheck)} books with longer title than {lengthCheck} symbols");

        }

        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            AgeRestriction ageRestriction;

            bool isValidEnum =
                Enum.TryParse<AgeRestriction>(command, true, out ageRestriction);

            if (!isValidEnum) return String.Empty;

            var bookTitles = context
                .Books
                .Where(b => b.AgeRestriction == ageRestriction)
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            foreach (var bookTitle in bookTitles)
            {
                sb.AppendLine(bookTitle);
            }


            return sb.ToString().TrimEnd();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var goldenBookTitles = context
                .Books
                .Where(b => b.Copies < 5000 && b.EditionType == EditionType.Gold)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var book in goldenBookTitles)
            {
                sb.AppendLine(book);
            }


            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var books = context
                .Books
                .Where(b => b.Price > 40)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - ${book.Price:f2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            var bookTitles = context
                .Books
                .Where(b => b.ReleaseDate.Value.Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToArray();

            foreach (var bookTitle in bookTitles)
            {
                sb.AppendLine(bookTitle);
            }

            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var bookFilters = input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(i => i.ToLower())
                .ToArray();

            var books = context
                .BooksCategories
                .Where(bc => bookFilters.Contains(bc.Category.Name.ToLower()))
                .Select(bc => bc.Book.Title)
                .OrderBy(bc => bc)
                .ToList();

            foreach (var title in books)
            {
                sb.AppendLine(title);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();
            //This doesn't work in Judge for some reason.
            //DateTime dateFilter = DateTime.Parse(date);
            var dateSplit = date.Split('-');
            int day = int.Parse(dateSplit[0]);
            int month = int.Parse(dateSplit[1]);
            int year = int.Parse(dateSplit[2]);
            DateTime dateFilter = new DateTime(year,month,day);

            var books = context
                .Books
                .Where(b => b.ReleaseDate < dateFilter)
                .OrderByDescending(b => b.ReleaseDate)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                })
                .ToArray();


            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var authorsFiltered = context
                .Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName)
                .ToArray();
  

            foreach (var authorName in authorsFiltered)
            {
                sb.AppendLine(authorName.FullName);
            }
            return sb.ToString().TrimEnd();
        }

        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            string filter = input.ToLower();

            var books = context
                .Books
                .Where(b => b.Title.ToLower().Contains(filter))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToArray();

            foreach (var book in books)
            {
                sb.AppendLine(book);
            }


            return sb.ToString().TrimEnd();
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var booksByAuthor = context
                .Books
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(b => b.BookId)
                .Select(b => new
                {
                    b.Title,
                    AuthorFullName = $"{b.Author.FirstName} {b.Author.LastName}"
                })
                .ToArray();

            foreach (var book in booksByAuthor)
            {
                sb.AppendLine($"{book.Title} ({book.AuthorFullName})");
            }


            return sb.ToString().TrimEnd();
        }

        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int count = context
                .Books
                .Where(b => b.Title.Length > lengthCheck)
                .ToArray()
                .Count();

            return count;
        }

    }
}
