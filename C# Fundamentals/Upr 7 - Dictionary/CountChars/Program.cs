using System;
using System.Collections.Generic;
using System.Linq;

namespace CountChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            for (int i = 0; i <= input.Length - 1; i++)
            {
                for (int j = 0; j <= input[i].Length - 1; j++)
                {
                    char symbol = input[i][j];
                    if (!dictionary.ContainsKey(symbol))
                    {
                        dictionary.Add(symbol, 1);
                    }
                    else { dictionary[symbol]++; }
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
