using System;
using System.Text;
using System.Text.RegularExpressions;
namespace DigitsLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder symbols = new StringBuilder();

            for (int i = 0; i <= input.Length-1; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Append(input[i]);
                }
           if (char.IsLetter(input[i]))
                {
                    letters.Append(input[i]);
                }
                else if (!char.IsLetter(input[i]) && !char.IsDigit(input[i]))
                {
                    symbols.Append(input[i]);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(symbols);
        }
    }
}
