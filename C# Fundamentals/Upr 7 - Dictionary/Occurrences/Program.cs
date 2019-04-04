using System;
using System.Collections.Generic;
using System.Linq;

namespace Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] languages = Console.ReadLine().Split().ToArray();
            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (var item in languages)
            {
                string lowercaseWord = item.ToLower();
                if (counts.ContainsKey(lowercaseWord))
                {
                    counts[lowercaseWord]++;
                }
                else { counts.Add(lowercaseWord, 1); }
            }
            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }
        }
    }
}
