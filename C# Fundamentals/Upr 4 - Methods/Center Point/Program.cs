using System;

namespace Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double lenght1 = Math.Sqrt(x1 * x1 + y1 * y1);
            double lenght2 = Math.Sqrt(x2 * x2 + y2 * y2);
            if (lenght1 >= lenght2)
            {

                Console.WriteLine($"({x2}, {y2})");
            }
            else if (lenght1 < lenght2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}
