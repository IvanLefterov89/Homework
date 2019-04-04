using System;
using System.Collections.Generic;
using System.Linq;
namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, int>();
            var sorted = new Dictionary<string, int>();
            var participants = new Dictionary<string, Dictionary<string, List<int>>>();
            var list = new List<string>();
         
            while (input != "no more time")
            {
                string[] commands = input.Split(" -> ");
                if (!dictionary.ContainsKey(commands[1]))
                {

                    dictionary.Add(commands[1], 0);
                    participants.Add(commands[1], new Dictionary<string, List<int>>());
                    
                }

                if (!sorted.ContainsKey(commands[0]))
                    sorted.Add(commands[0], int.Parse(commands[2]));
                else if (sorted.ContainsKey(commands[0]))
                    sorted[commands[0]] += int.Parse(commands[2]);

                if (dictionary.ContainsKey(commands[1]))
                {
                    dictionary[commands[1]]++;
                    if (participants[commands[1]].ContainsKey(commands[0]))
                    {
                        var comparer = participants[commands[1]][commands[0]];
                        if (int.Parse(commands[2]) >= comparer[0])
                        {
                            participants[commands[1]][commands[0]].Remove(comparer[0]);
                            participants[commands[1]][commands[0]].Add(int.Parse(commands[2]));
                            dictionary[commands[1]]--;
                            sorted[commands[0]] = int.Parse(commands[2]);
                        }
                        if (int.Parse(commands[2]) < comparer[0])
                        {
                            dictionary[commands[1]]--;
                            sorted[commands[0]] = comparer[0];
                        }

                    }
                    else if (!participants[commands[1]].ContainsKey(commands[0]))
                    {
                        participants[commands[1]].Add(commands[0], new List<int>());
                        participants[commands[1]][commands[0]].Add(int.Parse(commands[2]));
                    }
                    
                  
                }
                input = Console.ReadLine();
            }
            
            foreach (var item in dictionary.OrderByDescending(x=>x.Value))
            {
                
                Console.WriteLine($"{item.Key}: {item.Value} participants");
                var sort = participants[item.Key];
                int i = 1;

                foreach (var item1 in sort.OrderByDescending(x => x.Value[0]).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"{i}. {item1.Key} <::> {item1.Value[0]}");
                    i++;
                }
            }
            int count = 1;
            Console.WriteLine("Individual standings:");
            foreach (var item in sorted.OrderByDescending(x => x.Value).ThenBy(x=>x.Key))
            {                
                Console.WriteLine($"{count}. {item.Key} -> {item.Value}");
                count++;
            }
            
        }
    }
}
