using System;

namespace Sign
{
    internal class Program
    {
        private static void Printsign(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number == 0)
            {
                Console.WriteLine($"The number {number} is zero.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }


        }

        private static void Main(string[] args)
        {
           int number = int.Parse(Console.ReadLine());
            Printsign(number);
          
        }
    }
}
