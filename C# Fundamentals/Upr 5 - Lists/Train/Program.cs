using System;
using System.Collections.Generic;
using System.Linq;
namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] command1 = command.Split();
                command = command1[0];
                switch (command)
                {
                    case "Add":
                        {
                            wagons.Add(int.Parse(command1[1]));
                            break;
                        }
                    default:
                        {
                            for (int i = 0; i <= wagons.Count - 1; i++)
                            {
                                if (wagons[i] + int.Parse(command1[0]) <= maxCapacity)
                                {
                                    while ((wagons[i] + int.Parse(command1[0])) <= maxCapacity)
                                    {
                                        wagons[i] += int.Parse(command1[0]);
                                        break;
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
