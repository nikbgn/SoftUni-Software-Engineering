using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < numOfArticles; i++)
            {
                string[] articleInfo = Console.ReadLine().Split(", ");
                Article currArticle = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);
                articles.Add(currArticle);
            }
            string filterBy = Console.ReadLine();
            switch (filterBy)
            {
                case "title":
                    foreach (var article in articles.OrderBy(x => x.Title))
                    {
                        Console.WriteLine(article);
                    }
                    break;
                case "content":
                    foreach (var article in articles.OrderBy(x => x.Content))
                    {
                        Console.WriteLine(article);
                    }
                    break;
                case "author":
                    foreach (var article in articles.OrderBy(x => x.Author))
                    {
                        Console.WriteLine(article);
                    }
                    break;
                default:
                    break;
            }

        }
    }




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

        public override string ToString() => $"{Title} - {Content}: {Author}";

    }
}
