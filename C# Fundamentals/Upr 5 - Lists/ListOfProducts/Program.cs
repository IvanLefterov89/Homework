using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
               
            }
            products.Sort();
            int count = 0;
            foreach(var item in products)
            {
                count++;
                Console.WriteLine($"{count}.{item}");
            }
        }
    }
}
