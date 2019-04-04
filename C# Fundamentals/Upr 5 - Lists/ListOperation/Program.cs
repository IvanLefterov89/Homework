using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] command1 = command.Split();
                command = command1[0];
                // Metod
                ExecuteCommand(numbers, command1);
                command = Console.ReadLine();
                
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ExecuteCommand(List<int> numbers, string[] command1)
        {
            if (command1[0] == "Add")
            {
                numbers.Add(int.Parse(command1[1]));
            }
            else if (command1[0] == "Remove")
            {

                if (int.Parse(command1[1]) >= 0 && int.Parse(command1[1]) < numbers.Count)
                {
                    numbers.RemoveAt(int.Parse(command1[1]));
                }
                else
                {
                    Console.WriteLine("Invalid index");

                }
            }
            else if (command1[0] == "Insert")
            {
                if (int.Parse(command1[2]) >=0 && int.Parse(command1[2]) < numbers.Count)
                {
                    numbers.Insert(int.Parse(command1[2]), int.Parse(command1[1]));
                }
                else
                {
                    Console.WriteLine("Invalid index");

                }

            }
            else if (command1[0] == "Shift")
            {

                if (command1[1] == "left")
                {
                    for (int i = 0; i < int.Parse(command1[2]); i++)
                    {
                        numbers.Add(numbers[0]);
                        numbers.Remove(numbers[0]);
                    }
                }
                if (command1[1] == "right")
                {
                    for (int i = 0; i < int.Parse(command1[2]); i++)
                    {
                        numbers.Insert(0, numbers[numbers.Count - 1]);
                        numbers.RemoveAt(numbers.Count - 1);

                    }
                }               
            }

        }
    }
}
