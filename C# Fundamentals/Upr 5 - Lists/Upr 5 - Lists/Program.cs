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
            bool isTrue = false;
            
                string command = Console.ReadLine();
            while (command != "end")
            {
              string[] command1 = command.Split();
                command = command1[0];
                switch (command)
                {
                    case "Add":
                        {
                            isTrue = true;
                            numbers.Add(int.Parse(command1[1]));
                            break;
                        }
                    case "Remove":
                        {
                            isTrue = true;
                            numbers.Remove(int.Parse(command1[1]));
                            break;
                        }
                    case "RemoveAt":
                        {
                            isTrue = true;
                            numbers.RemoveAt(int.Parse(command1[1]));
                            break;
                        }
                    case "Insert":
                        {
                            isTrue = true;
                            numbers.Insert(int.Parse(command1[2]), int.Parse(command1[1]));
                            break;
                        }

                    case "Contains":
                        {
                            if (numbers.Contains(int.Parse(command1[1])))
                            {
                                Console.WriteLine("Yes");
                            }
                            else Console.WriteLine("No such number");
                            break;
                        }
                    case "PrintEven":
                        {
                            for (int i = 0; i <= numbers.Count - 1; i++)
                            {
                                if (numbers[i] % 2 == 0)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "PrintOdd":
                        {
                            for (int i = 0; i <= numbers.Count - 1; i++)
                            {
                                if (numbers[i] % 2 != 0)
                                {
                                    Console.Write(numbers[i] + " ");
                                }
                            }
                            Console.WriteLine();
                            break;
                        }
                    case "GetSum":
                        {
                            Console.WriteLine(numbers.Sum());                           
                            break;
                        }
                    case "Filter":
                        {
                            List<int> numbers1 = new List<int>();
                            if (command1[1] == "<")
                            {
                                for (int i = 0; i <= numbers.Count - 1; i++)
                                {
                                    if (numbers[i] < int.Parse(command1[2]))
                                    {
                                        numbers1.Add(numbers[i]);
                                    }
                                }
                            }
                            if (command1[1] == ">")
                            {
                                for (int i = 0; i <= numbers.Count - 1; i++)
                                {
                                    if (numbers[i] > int.Parse(command1[2]))
                                    {
                                        numbers1.Add(numbers[i]);
                                    }
                                }
                            }
                            if (command1[1] == "<=")
                            {
                                for (int i = 0; i <= numbers.Count - 1; i++)
                                {
                                    if (numbers[i] <= int.Parse(command1[2]))
                                    {
                                        numbers1.Add(numbers[i]);
                                    }
                                }

                            }
                            if (command1[1] == ">=")
                            {
                                for (int i = 0; i <= numbers.Count - 1; i++)
                                {
                                    if (numbers[i] >= int.Parse(command1[2]))
                                    {
                                        numbers1.Add(numbers[i]);
                                    }
                                }
                            }
                            Console.WriteLine(string.Join(" ", numbers1));
                            break;
                        }
                 //   default: { break; }
                }
                command = Console.ReadLine();
            }
            if (isTrue)
            {
                 Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
