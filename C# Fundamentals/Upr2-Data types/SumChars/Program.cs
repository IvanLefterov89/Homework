using System;

namespace SumChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofLetters = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= numberofLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
