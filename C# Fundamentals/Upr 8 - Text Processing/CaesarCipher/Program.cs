using System;
using System.Text;
namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encrypt = new StringBuilder();
            for (int i = 0; i <= input.Length - 1; i++)
            {
                encrypt.Append(char.ConvertFromUtf32(input[i] + 3));
            }
            Console.WriteLine(encrypt);
        }
    }
}
