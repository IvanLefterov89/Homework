using System;
using System.Collections.Generic;
using System.Linq;
namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Students= new Dictionary<string, int>();
            Dictionary<string, int> Submittions = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input!="exam finished")
            {
                
                string[] inputLine = input.Split("-");
                string name = inputLine[0];
                if (inputLine[1] == "banned")
                {
                    Students.Remove(name);
                }
                else
                {
                    string language = inputLine[1];
                    int points = int.Parse(inputLine[2]);

                    if (!Students.ContainsKey(name))
                    {
                        Students[name] = points;
                    }
                    else if (points > Students[name])
                    {
                        Students[name] = points;
                    }
                    if (!Submittions.ContainsKey(language))
                    {
                        Submittions[language] = 0;
                    }
                    Submittions[language]++;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Results: ");
            foreach (var item in Students.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key} | {item.Value}");

            }
         Console.WriteLine("Submissions: ");
            foreach (var item in Submittions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");

            }
        }
    }
}
