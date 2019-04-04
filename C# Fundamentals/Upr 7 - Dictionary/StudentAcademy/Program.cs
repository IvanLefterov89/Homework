using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, double>();
            var newDictionary = new Dictionary<string, int>();
            var output = new Dictionary<string, double>();
           
            for (int i = 1; i <= n; i++)
            {
               // count = 1;
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, grade);
                    newDictionary.Add(name, 1);
                }
               else if (dictionary.ContainsKey(name))
                {
                   // count++;
                    dictionary[name] += grade;
                    newDictionary[name]++;
                    
                }
            } 
            foreach (var item in dictionary.OrderByDescending(x=>x.Value).ToList())
            {
                foreach (var item1 in newDictionary)
                {
                    if (item.Key == item1.Key)
                    {
                        double average = item.Value / item1.Value;
                        output.Add(item.Key, average);
                        
                    }
                }
            }
            foreach (var item in output.OrderByDescending(x=>x.Value).ToList())
            {
                if (item.Value>=4.50)
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
