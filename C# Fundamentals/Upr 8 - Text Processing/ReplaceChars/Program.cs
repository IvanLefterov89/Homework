using System;
using System.Text;
namespace ReplaceChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] newstring = input.ToCharArray();
            StringBuilder sb = new StringBuilder();
            sb.Append(newstring[0]);
            for (int i = 1; i <= input.Length - 1; i++)
            {
                
                if (input[i] != input[i-1])
                {
                    sb.Append(newstring[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
