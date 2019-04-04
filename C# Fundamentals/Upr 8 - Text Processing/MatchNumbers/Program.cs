using System;

namespace MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            double compare = 0;
            string output = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                bool isTrue = double.TryParse(input[i], out compare);
                if (isTrue)
                {
                    output += input[i] + " ";
                }
            }
            Console.WriteLine(output);
        }
    }
}
