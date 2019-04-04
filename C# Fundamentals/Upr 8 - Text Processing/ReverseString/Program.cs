using System;
using System.Text;
namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (string word in input)
            {
                int count = word.Length;
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
