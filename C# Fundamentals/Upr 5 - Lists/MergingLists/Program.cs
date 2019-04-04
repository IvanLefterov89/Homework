using System;
using System.Collections.Generic;
using System.Linq;
namespace MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> output = new List<int>();
            for (int i = 0; i < (numbers.Count + numbers2.Count - 1); i++)
            {
                if (i <= numbers.Count - 1 && i <= numbers2.Count - 1)
                {
                    output.Add(numbers[i]);
                    output.Add(numbers2[i]);
                }
                if (i <= numbers.Count - 1 && i > numbers2.Count - 1)
                {
                    output.Add(numbers[i]);
                }
                if (i > numbers.Count - 1 && i <= numbers2.Count - 1)
                {
                    output.Add(numbers2[i]);
                }
                if (i > numbers.Count - 1 && i > numbers2.Count - 1)
                {
                    break;
                }
            }
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}
