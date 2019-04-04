using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split().ToArray();
            List<string> topIntegers = new List<string>();
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                if (numbers[i].Length % 2 == 0)
                {
                    topIntegers.Add(numbers[i]);
                }
            }

            foreach (var item in topIntegers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
