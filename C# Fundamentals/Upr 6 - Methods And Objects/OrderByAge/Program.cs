using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            var info = new Sorted();
            List<Sorted> OutputInfo = new List<Sorted>();

            while (command != "End")
            {
                string[] input = command.Split();
                info.Name = input[0];
                info.IDNumber = input[1];
                info.age = int.Parse(input[2]);
                OutputInfo.Add(new Sorted { Name = info.Name, IDNumber = info.IDNumber, age = info.age });
                command = Console.ReadLine();
            }
           var result= OutputInfo.OrderBy(x => x.age).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Sorted
    {

        public string Name { get; set; }
        public string IDNumber { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {IDNumber} is {age} years old.";
        }
    }
}
