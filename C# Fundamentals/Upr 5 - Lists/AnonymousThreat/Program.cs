using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();
            string output = "";
            int index = 0;
            while (command != "3:1")
            {
                string[] shortcommand = command.Split();
                if (shortcommand[0] == "merge")
                {
                   // output += input[int.Parse(shortcommand[1])];
                    for (int i = int.Parse(shortcommand[1]); i < int.Parse(shortcommand[2]); i++)
                    {
                        if (i < input.Count - 1)
                        {
                            input[int.Parse(shortcommand[1])] += input[i+1];
                            input.Remove(input[i+1]);
                        }
                        if (i >= input.Count-1)
                        {
                            input[int.Parse(shortcommand[1])] += input[input.Count-1];
                            input.Remove(input[input.Count-1]);
                            break;
                        }
                    }
                }
                if (shortcommand[0] == "divide")
                {
                    for (int i = int.Parse(shortcommand[1]); i <= int.Parse(shortcommand[2]); i++)
                    {
                        input[i] += input[i + 1];
                    }
                }
               // index = int.Parse(shortcommand[1]);
                command = Console.ReadLine();
            }
            foreach(var item in input)
                Console.Write(item+ " ");
            
        }
    }
}
