using System;
using System.Linq;
namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrom = Console.ReadLine();
           
            while (palindrom != "END")
            {
                
                string reverse = "";
                for (int i = palindrom.Length-1; i >= 0; i--)
                {
                    reverse += palindrom[i];
                }
                if (palindrom == reverse)
                {
                    Console.WriteLine("true");
                }
                else Console.WriteLine("false");
                palindrom = Console.ReadLine();
            }
        }
    }
}
