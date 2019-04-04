using System;

namespace Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i <= input.Length-1; i++)
            {
                char symbol = input[i];
                if (symbol == 'a' || symbol == 'e' || symbol == 'o' || symbol == 'u' || symbol == 'i' || symbol == 'A' || symbol == 'E' || symbol == 'O' || symbol == 'U' || symbol == 'I')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
