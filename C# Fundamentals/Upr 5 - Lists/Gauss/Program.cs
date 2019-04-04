using System;
using System.Collections.Generic;
using System.Linq;
namespace Gauss
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
          //  int longestCount = numbers.Count;
            
            for (int i = 0; i < numbers.Count-1; i++)
            {
                
               // numbers[i] += numbers[numbers.Count -1];
               numbers.RemoveAll(n=>n<0); 
               
            }
            numbers.Reverse();
            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
           else Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
