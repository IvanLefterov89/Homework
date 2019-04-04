using System;
using System.Collections.Generic;
using System.Linq;
namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var dictionary = new Dictionary<string, double>();
            var newdictionary = new Dictionary<string, double>();
            while (input != "buy")
            {
                string[] command = input.Split();
                if (!dictionary.ContainsKey(command[0]))
                {
                    dictionary.Add(command[0], double.Parse(command[2]));
                    newdictionary.Add(command[0], double.Parse(command[1]));
                   
                }
                else
                {
                    dictionary[command[0]] += double.Parse(command[2]);
                    newdictionary[command[0]] = double.Parse(command[1]);

                }
                input = Console.ReadLine();
            }
            foreach (var item in dictionary)
            {
                foreach (var item1 in newdictionary)
                {
                    if (item.Key == item1.Key)
                    Console.WriteLine($"{item.Key} -> {item.Value * item1.Value:F2}");
                }
               
            }
            
        }
    }
}
