using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerDay = int.Parse(Console.ReadLine());
            double sum = 0;
            double tax = 0;
            double total = 0;
            for (int i = 1; i <= days; i++)
            {
                sum = 0;
                for (int j = 1; j <= hoursPerDay; j++)
                {
                    tax = 0;
                    if ((i % 2 == 0) && (j%2!=0))
                    {
                        tax = 2.5;
                    }
                    if ((i % 2 != 0) && (j % 2 == 0))
                    {
                        tax = 1.25;
                    }
                    else if (((i % 2 == 0) && (j % 2 == 0)) || ((i % 2 != 0) && (j % 2 != 0)))
                    { tax = 1; }
                    sum = sum + tax;
                }
                Console.WriteLine($"Day: {i} - {sum:F2} leva");
                total = total + sum;
            }
            
            Console.WriteLine($"Total: {total:F2} leva");
        }
    }
}
