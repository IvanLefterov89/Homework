using System;
using System.Collections.Generic;
using System.Linq;
namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>(); // syzdavame prazen rechnik 
            foreach (var number in numbers)
            {
                if (counts.ContainsKey(number))// proverqvame dali chisloto ot spisyka veche se sydyrja v rechnika
                {
                    counts[number]++; // ako se sydyrja broikata na chisloto narastva
                }
                else { counts.Add(number, 1); } // ako ne se sydyrja se dobavq v spisyka s nachalen broi 1
            }
            foreach (var number in counts)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
