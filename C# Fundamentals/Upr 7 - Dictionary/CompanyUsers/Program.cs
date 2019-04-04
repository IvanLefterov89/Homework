using System;
using System.Collections.Generic;
using System.Linq;
namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string course = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();
            var newDictionary = new Dictionary<string, List<string>>();
            while (course != "End")
            {
                string[] commands = course.Split(" -> ");
                if (!dictionary.ContainsKey(commands[0]))
                {
                    dictionary.Add(commands[0], 0);
                    newDictionary.Add(commands[0], new List<string>());
                }
                if (dictionary.ContainsKey(commands[0]))
                {
                    dictionary[commands[0]]++;
                    
                    newDictionary[commands[0]].Add(commands[1]);
                    for (int i = 0; i < newDictionary[commands[0]].Count-1; i++)
                    {
                        if (commands[1] == newDictionary[commands[0]][i])
                        {
                            newDictionary[commands[0]].RemoveAt(newDictionary[commands[0]].Count - 1);
                        }
                    }
                }
                course = Console.ReadLine();
            }

            foreach (var item in dictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                foreach (var item1 in newDictionary)
                {
                    if (item.Key == item1.Key)
                        
                        Console.WriteLine($"-- {string.Join("\n-- ", item1.Value)}");
                }
            }
        }
    }
}
