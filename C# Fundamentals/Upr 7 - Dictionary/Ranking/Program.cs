using System;
using System.Collections.Generic;
using System.Linq;
namespace Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string course = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();
            var newDictionary = new Dictionary<string, Dictionary<string, double>>();

            while (course != "end of contests")
            {
                string[] commands = course.Split(":");
                if (!dictionary.ContainsKey(commands[0]))
                {
                    dictionary.Add(commands[0], 0);
                }
                course = Console.ReadLine();
            }
            course = Console.ReadLine();
            while (course != "end of submissions")
            {
                string[] commands = course.Split("=>");
                if (dictionary.ContainsKey(commands[0]) && !newDictionary.ContainsKey(commands[2]))
                {
                    dictionary[commands[0]] += int.Parse(commands[3]);
                    newDictionary.Add(commands[2], new Dictionary<string, double>());
                    newDictionary[commands[2]].Add(commands[0], int.Parse(commands[3]));
                }
               else if (newDictionary.ContainsKey(commands[2]))
                {        
                    newDictionary[commands[2]].Add(commands[0], int.Parse(commands[3]));
                }
               else if (dictionary.ContainsKey(commands[0]) && newDictionary.ContainsKey(commands[2]))
                {
                    continue;
                }
                course = Console.ReadLine();
            }
            double sum = 0;
            foreach (var item in newDictionary.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}");
                
                foreach (var item1 in item.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"# {item1.Key}->{item1.Value}");
                    sum += item1.Value;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
