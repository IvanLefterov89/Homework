using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToRemove = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

            while (input.Contains(stringToRemove))
                { 
                 int temp = input.IndexOf(stringToRemove);
                 input = input.Remove(temp, stringToRemove.Length);
               }
            Console.WriteLine(input);
            
        }
    }
}
