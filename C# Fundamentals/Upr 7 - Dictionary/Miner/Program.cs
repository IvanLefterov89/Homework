using System;
using System.Collections.Generic;
using System.Linq;
namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            string recourse = Console.ReadLine();
           
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            while (recourse != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(recourse))
                {
                    dictionary.Add(recourse, quantity);
                }
                else
                {
                    dictionary[recourse] += quantity;
                }
                recourse = Console.ReadLine();
             
              
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
