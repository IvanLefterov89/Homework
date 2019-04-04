using System;

namespace Decrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            int offset = int.Parse(Console.ReadLine());
            int numberOfLetters = int.Parse(Console.ReadLine());
            char decrypt = ' ';
            string message = "";
            for (int i = 0; i < numberOfLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                for (int j = 0; j <= offset; j++)
                {
                    decrypt = letter++;
                }
                message +=decrypt; 
                
            }
            Console.WriteLine(message);
        }
    }
}
