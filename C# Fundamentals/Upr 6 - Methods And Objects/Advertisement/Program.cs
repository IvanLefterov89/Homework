using System;
using System.Collections.Generic;
using System.Linq;
namespace Advertisement
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors =  { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int input = int.Parse(Console.ReadLine());
            Random message = new Random();
           
            for (int i = 0; i < input; i++)
            {
                int randIndex = message.Next(phrases.Length);
                int randIndex1 = message.Next(events.Length);
                int randIndex2 = message.Next(authors.Length);
                int randIndex3 = message.Next(cities.Length);
                Console.WriteLine($"{phrases[randIndex]} {events[randIndex1]} {authors[randIndex2]} – {cities[randIndex3]}.");
               // Console.WriteLine();
            }
        }
    }
}
