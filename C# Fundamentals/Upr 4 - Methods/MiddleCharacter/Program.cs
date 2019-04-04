using System;

namespace MiddleCharacter
{
    class Program
    {
        private static void MiddleChar(string input)
        {
            if (input.Length % 2 == 0)
            {
                Console.WriteLine($"{input[input.Length / 2 - 1]}" + $"{input[input.Length / 2]}");
            }
            else if (input.Length % 2 != 0)
            {
                Console.WriteLine($"{input[input.Length / 2]}");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            MiddleChar(input);

        }
    }
}
