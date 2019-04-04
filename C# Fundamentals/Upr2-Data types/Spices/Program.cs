using System;

namespace Spices
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYeald = int.Parse(Console.ReadLine());              
            int days = 0;
            int sum = 0;
            
            while (startingYeald >= 100)
            {
             
                sum += startingYeald - 26;
                startingYeald -= 10;                            
                days++;
               
            }
            if (sum >= 26)
            {
                sum -= 26;
            }
            Console.WriteLine(days);
                Console.WriteLine(sum);
            
         
        }
    }
}
