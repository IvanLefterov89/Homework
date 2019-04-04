using System;
using System.Collections.Generic;
using System.Linq;

namespace Article2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            Article article = new Article();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(", ");
                article.Title = command[0];
                article.Content = command[1];
                article.Author = command[2];
               
                 
                articles.Add(new Article { Title = article.Title, Content = article.Content, Author = article.Author });

            }
            string criteria = Console.ReadLine();
            if (criteria == "title")
            {
             var result = articles.OrderBy(x => x.Title).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            if (criteria == "content")
            {
            var result = articles.OrderBy(x => x.Content).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
            if (criteria == "author")
            {
              var result = articles.OrderBy(x => x.Author).ToList();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            
        }
        class Article // syzdavane na klas
        {

            public string Title { get; set; }  // syzdavane na properties
            public string Content { get; set; }// syzdavane na properties
            public string Author { get; set; }// syzdavane na properties

           
            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }
}
