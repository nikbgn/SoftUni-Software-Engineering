using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleInfo = Console.ReadLine().Split(", ");
            string title = articleInfo[0];
            string content = articleInfo[1];
            string author = articleInfo[2];
            int numOfCommandsToFollow = int.Parse(Console.ReadLine());

            Article article = new Article(title, content, author);

            for (int i = 0; i < numOfCommandsToFollow; i++)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                string cmd = command[0];
                command.RemoveAt(0);
                string cmdValue = string.Join(" ", command);

                switch (cmd)
                {
                    case "Edit:":
                        article.Edit(cmdValue);
                        break;
                    case "ChangeAuthor:":
                        article.ChangeAuthor(cmdValue);
                        break;
                    case "Rename:":
                        article.ChangeTitle(cmdValue);
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine(article.ToString());

        }
    }


    //Class


    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }


        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }


        public void Edit(string editedText) => Content = editedText;


        public void ChangeAuthor(string author) => Author = author;

        public void ChangeTitle(string title) => Title = title;

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}
