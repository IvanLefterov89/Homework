using System;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ');

            var oldelement = 0.0;
            for (int i = 0; i <= number.Length -1; i++)
            {
                 oldelement = double.Parse(number[i]);
                Console.WriteLine($"{string.Join(" ", oldelement)} => {Math.Round(oldelement, 0, MidpointRounding.AwayFromZero)} ");
            }
            
           
        }
    }
}
