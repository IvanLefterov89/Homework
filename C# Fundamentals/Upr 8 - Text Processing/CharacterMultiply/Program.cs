using System;

namespace CharacterMultiply
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double sum = 0;
            if (input[0].Length >= input[1].Length)
            {
                for (int i = 0; i <= input[0].Length - 1; i++)
                {
                    if (i <= input[1].Length - 1)
                    {
                        sum += input[0][i] * input[1][i];
                    }
                    if (i > input[1].Length - 1)
                    {
                        sum += input[0][i];
                    }
                }
            }
            if (input[0].Length < input[1].Length)
            {
                for (int i = 0; i <= input[1].Length - 1; i++)
                {
                    if (i <= input[0].Length - 1)
                    {
                        sum += input[0][i] * input[1][i];
                    }
                    if (i > input[0].Length - 1)
                    {
                        sum += input[1][i];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
