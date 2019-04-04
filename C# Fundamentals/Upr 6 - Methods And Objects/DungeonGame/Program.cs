using System;
using System.Collections.Generic;
using System.Linq;

namespace DungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            List<string> rooms = Console.ReadLine().Split("|").ToList();
            // List<string> output = new List<string>();
            bool isTrue = false;
            for (int i = 0; i <= rooms.Count - 1; i++)
            {
                string[] command = rooms[i].Split();
                int digit = int.Parse(command[1]);
                if (command[0] == "chest")
                {
                    Console.WriteLine($"You found {digit} coins.");                  
                    coins += digit;
                }
                if (command[0] == "potion")
                {
                    
                   // Console.WriteLine($"You healed for {int.Parse(command[1])} hp.");

                    if (health + digit > 100)
                    {
                        Console.WriteLine($"You healed for {100 - health} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {digit} hp.");
                        Console.WriteLine($"Current health: {health + digit} hp.");
                        health += digit;
                    }
                    
                }
                if (command[0] != "chest" && command[0] != "potion")
                {
                    health -= digit;
                    if (health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        isTrue = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                }
            }
            if (!isTrue)
            {
                Console.WriteLine($"You've made it!");
                Console.WriteLine($"Coins: {coins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
