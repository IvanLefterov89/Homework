using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, string>();
            for (int i = 1; i <= number; i++)
            {
                string command = Console.ReadLine();
                string[] commands = command.Split();
                if (commands[0] == "register")
                {
                    if (!dictionary.ContainsKey(commands[1]))
                    {
                        dictionary.Add(commands[1], commands[2]);
                        Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                    }
                   else if (dictionary.ContainsKey(commands[1]) && dictionary.ContainsValue(commands[2]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");
                    }
                    else if (dictionary.ContainsKey(commands[1]) && !dictionary.ContainsValue(commands[2]))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {commands[2]}");
                    }
                   
                       
                    
                }
                if (commands[0] == "unregister")
                {
                    if (!dictionary.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"ERROR: user {commands[1]} not found");
                    }
                  
                    else
                    {
                        Console.WriteLine($"{commands[1]} unregistered successfully");
                        dictionary.Remove(commands[1], out commands[1]);
                    }
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
