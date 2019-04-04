using System;
using System.Text;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ");
            string inputText = Console.ReadLine();
            
            for (int i = 0; i <= bannedWords.Length - 1; i++)
            {
                StringBuilder temp = new StringBuilder();
                for (int j = 0; j <= bannedWords[i].Length - 1; j++)
                {
                    temp.Append("*");
                }
                while (inputText.Contains(bannedWords[i]))
                {
                   
                    inputText = inputText.Replace(bannedWords[i], temp.ToString());
                }
            }
            Console.WriteLine(inputText);
        }
    }
}
