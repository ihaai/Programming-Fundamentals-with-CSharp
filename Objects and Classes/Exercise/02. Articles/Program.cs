using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Articles
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
            var articleInfo = Console.ReadLine().Split(", ").ToList();

            Article article = new Article(articleInfo[0], articleInfo[1], articleInfo[2]);

            var numberOfLines = Console.ReadLine();

            for(int i = 0; i < int.Parse(numberOfLines); i++)
            {
                var input = Console.ReadLine().Split(':').Select(tr => tr.Trim()).ToList();

                if (input[0] == "Edit")
                    article.Content = input[1];
                if (input[0] == "ChangeAuthor")
                    article.Author = input[1];
                if (input[0] == "Rename")
                    article.Title = input[1];
            }

            Console.WriteLine("{0} - {1}: {2}", article.Title, article.Content, article.Author);
        }
    }
}
