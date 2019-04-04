using System;
using System.Text;
namespace ExtractFIle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");
            string newstring = input[input.Length-1];
            string[] nameAndExt = newstring.Split(".");
           
            Console.WriteLine($"File name: {nameAndExt[0]}");
            Console.WriteLine($"File extension: {nameAndExt[1]}");
            
        }
    }
}
