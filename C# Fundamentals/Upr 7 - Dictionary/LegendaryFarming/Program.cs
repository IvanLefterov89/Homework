using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary["fragments"] = 0;
            dictionary["motes"] = 0;
            dictionary["shards"] = 0;
            Dictionary<string, int> dictionary2 = new Dictionary<string, int>();
            string resourse = "";
            int quantity = 0;
            bool isTrue = false;
            while (!isTrue)
            {
                for (int i = 0; i < input.Length - 1; i+=2)
                {                  
                        resourse = input[i+1].ToLower();                                     
                        quantity = int.Parse(input[i]);
                    if (resourse == "fragments" || resourse == "motes" || resourse == "shards")
                    {
                        if (!dictionary.ContainsKey(resourse))
                        {
                            dictionary.Add(resourse, quantity);
                        }
                        else
                        {

                            dictionary[resourse] += quantity;
                        }
                    }
                    else
                    {
                        if (!dictionary2.ContainsKey(resourse))
                        {
                            dictionary2.Add(resourse, quantity);
                        }
                        else
                        {
                            dictionary2[resourse] += quantity;
                        }
                    }
                    if (dictionary["fragments"] >= 250 || dictionary["motes"] >= 250 || dictionary["shards"] >= 250)
                    {
                        dictionary[resourse] -= 250;
                        if (resourse == "fragments")
                            Console.WriteLine($"Valanyr obtained!");
                        if (resourse == "motes")
                            Console.WriteLine($"Dragonwrath obtained!");
                        if (resourse == "shards")
                            Console.WriteLine($"Shadowmourne obtained!");
                        isTrue = true;
                        break;
                    }
                }
                if (!isTrue)
                {
                    input = Console.ReadLine().Split();
                }
                                    
            }            
                      
                foreach (var item in dictionary.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                Console.WriteLine($"{item.Key}: {item.Value}");

            }
                foreach (var item in dictionary2.OrderBy(x=>x.Key))
                  {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
              
        }
    }
}
