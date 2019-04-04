using System;
using System.Collections.Generic;
using System.Linq;

namespace WordSynonims
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> synonyms = new List<string>();
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            for (int i = 1; i <= number; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary.Add(word, new List<string>());
                   
                }
                                   
                    dictionary[word].Add(synonim);
                }
            foreach (var item in dictionary)
            {
                
                    Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
                
            }
        }
    }
}
