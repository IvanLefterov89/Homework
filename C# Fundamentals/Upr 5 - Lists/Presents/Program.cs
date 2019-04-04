using System;
using System.Collections.Generic;
using System.Linq;
namespace Presents
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] houseMembers = input.Split("@").Select(int.Parse).ToArray();
            int lenght = 0;
            while (input != "Merry Xmas!")
            {
                string[] commands = input.Split();
                if (commands[0] == "Jump")
                {
                    // lenght = int.Parse(commands[1]);
                    if (lenght + int.Parse(commands[1]) < houseMembers.Length && houseMembers[lenght + int.Parse(commands[1])] >= 2)
                    {
                        houseMembers[lenght + int.Parse(commands[1])] -= 2;
                        lenght += int.Parse(commands[1]);
                    }
                    else if (lenght + int.Parse(commands[1]) >= houseMembers.Length && houseMembers[lenght - (lenght / houseMembers.Length) * houseMembers.Length] >= 2)
                    {
                        houseMembers[lenght - (lenght / houseMembers.Length) * houseMembers.Length] -= 2;
                        lenght += int.Parse(commands[1]);
                    }
                    else { Console.WriteLine($"House {lenght + int.Parse(commands[1])} will have a Merry Christmas."); }
                    
                }
                input = Console.ReadLine();
            }
            if (lenght <= houseMembers.Length)
            {
                Console.WriteLine($"Santa's last position was {lenght}.");
            }
            else Console.WriteLine($"Santa's last position was {lenght - (lenght / houseMembers.Length) * houseMembers.Length}.");
            int count = 0;
            for (int i = 0; i <= houseMembers.Length - 1; i++)
            {
                if (houseMembers[i] != 0)
                {
                    count++;
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"Santa has failed {count} houses.");
            }
            else Console.WriteLine($"Mission was successful.");
        }
    }
}
