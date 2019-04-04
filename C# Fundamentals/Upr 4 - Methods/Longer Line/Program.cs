using System;

namespace Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double lenght1 = Math.Sqrt(((x1 - x2) * (x1 -x2)) + ((y1 - y2)* (y1 - y2)));
            double lenght2 = Math.Sqrt(((x3 - x4) * (x3 - x4)) + ((y3 - y4) * (y3 - y4)));
            if (lenght1 >= lenght2)
            {
               if( Math.Sqrt(x1 * x1 + y1 * y1) >= Math.Sqrt(x2 * x2 + y2 * y2)) 
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                if (Math.Sqrt(x1 * x1 + y1 * y1) < Math.Sqrt(x2 * x2 + y2 * y2))
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else if (lenght1 < lenght2)
            {
                if (Math.Sqrt(x3 * x3 + y3 * y3) >= Math.Sqrt(x4 * x4 + y4 * y4))
                    Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
                if (Math.Sqrt(x3 * x3 + y3 * y3) < Math.Sqrt(x4 * x4 + y4 * y4))
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
        }
    }
}
