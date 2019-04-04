using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            int n = int.Parse(Console.ReadLine());
            Article article = new Article();
            article.Title = input[0];
            article.Content = input[1];
            article.Author = input[2];
            
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(": ");
                if (command[0] == "Edit")
                {
                    article.Edit(command[1]) ;
                }
                if (command[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(command[1]);
                }
                if (command[0] == "Rename")
                {
                     article.Rename(command[1]);
                }
            }
            Console.WriteLine($"{article.ToString()}");
        }
    }
    class Article // syzdavane na klas
    {
        
        public string Title { get; set; }  // syzdavane na properties
        public string Content { get; set; }// syzdavane na properties
        public string Author { get; set; }// syzdavane na properties

        public void Edit(string newContent) // sysdavane na metod
        {
            Content = newContent; // promqna stoinostta na metoda
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
