using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Articles_2._0
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articleStorage = new List<Article>();
            var numberOfArticles = Console.ReadLine();

            for (int i = 0; i < int.Parse(numberOfArticles); i++)
            {
                var articleInfo = Console.ReadLine().Split(", ").ToList();

                articleStorage.Add(new Article(articleInfo[0], articleInfo[1], articleInfo[2]));
            }

            var orderCriteria = Console.ReadLine();

            switch (orderCriteria)
            {
                case "title":
                    var titleOrder = articleStorage.OrderBy(tl => tl.Title).ToList();
                    foreach (Article tl in titleOrder)
                        Console.WriteLine("{0} - {1}: {2}", tl.Title, tl.Content, tl.Author);
                    break;

                case "content":
                    var contentOrder = articleStorage.OrderBy(ct => ct.Content).ToList();
                    foreach (Article ct in contentOrder)
                        Console.WriteLine("{0} - {1}: {2}", ct.Title, ct.Content, ct.Author);
                    break;

                case "author":
                    var authorOrder = articleStorage.OrderBy(au => au.Author).ToList();
                    foreach(Article au in authorOrder)
                        Console.WriteLine("{0} - {1}: {2}", au.Title, au.Content, au.Author);
                    break;
            }
        }
    }
}
