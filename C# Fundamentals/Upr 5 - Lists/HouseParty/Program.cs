using System;
using System.Collections.Generic;
using System.Linq;
namespace HouseParty
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> GuestList = new List<string>();
            
            for (int i = 0; i < number; i++)
            {

                string[] GuestName = Console.ReadLine().Split().ToArray();

                if (GuestName.Length == 3)
                {
                    if (!GuestList.Contains(GuestName[0]))
                    {
                        GuestList.Add(GuestName[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{GuestName[0]} is already in the list!");
                    }
                }

                if (GuestName.Length == 4)
                {
                    // John is not going
                    if (GuestList.Contains(GuestName[0]))
                    {
                        GuestList.Remove(GuestName[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{GuestName[0]} is not in the list!");
                    }
                }        
               
            }
            foreach (var item in GuestList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
