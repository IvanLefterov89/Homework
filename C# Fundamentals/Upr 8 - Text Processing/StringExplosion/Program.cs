using System;
using System.Text.RegularExpressions;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%?\d+";
            Regex order = new Regex(pattern);
            bool istrue = false;
            while (order.IsMatch(input))
            {
                int radius = int.Parse(order.Match(input).Value);
                int nextMatch = order.Match(input).NextMatch().Length;
                if (nextMatch >= radius || nextMatch==0)
                {
                    if (istrue)
                    {
                        radius++;
                        input = input.Remove(order.Match(input).Index, radius);
                    }
                    else if (!istrue)
                        input = input.Remove(order.Match(input).Index, radius);
                }
                if (nextMatch < radius && nextMatch!=0)
                {
                    input = input.Remove(order.Match(input).Index, radius);
                    input = input.Insert(order.Match(input).Index, ">");
                    istrue = true;
                }
                 
                
                Console.WriteLine(input);
            }

            
        }
    }
}
