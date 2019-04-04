using System;

namespace Upr2_Data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstnumber = long.Parse(Console.ReadLine());
            long secondnumber = long.Parse(Console.ReadLine());
            double thirdnumber = double.Parse(Console.ReadLine());
            long forthnumber = long.Parse(Console.ReadLine());
            double sum = Math.Round((firstnumber + secondnumber) / thirdnumber) * forthnumber;
            Console.WriteLine($"{sum}");
        }
    }
}
