using System;
using System.Collections.Generic;
using System.Linq;
namespace Upr_5___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] command1 = command.Split();
                command = command1[0];
                switch (command)
                {
                    case "Insert":
                        {
                           
                            numbers.Insert(int.Parse(command1[2]), int.Parse(command1[1]));
                            break;
                        }
                    case "Delete":
                        {
                         
                            numbers.RemoveAll(x => x == int.Parse(command1[1]));
                            break;
                        }
                    
                    
                       
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
