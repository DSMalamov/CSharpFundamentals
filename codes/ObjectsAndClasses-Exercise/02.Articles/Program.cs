using System;
using System.Collections.Generic;

namespace _02.Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string title = input[0];
                string content = input[1];
                string author = input[2];

                Article article = new Article(title, content, author);
                listOfArticles.Add(article);

            }

            foreach (var item in listOfArticles)
            {
                Console.WriteLine(item);
            }
            
            
        }
    }

    public class Article
    {
        public Article (string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
