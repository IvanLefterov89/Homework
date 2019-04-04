using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            if (a >= b && b >= c)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                return;
            }
            if (a >= c && c >= b)
            {
                Console.WriteLine(a);
                Console.WriteLine(c);
                Console.WriteLine(b);
                return;
            }
            if (b>=a && a >= c)
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
                Console.WriteLine(c);
                return;
            }
            if (b >= c && c >= a)
            {
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(a);
                return;
            }
            if (c >= a && a >= b)
            {
                Console.WriteLine(c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                return;
            }
            if (c >= b && b >= a)
            {
                Console.WriteLine(c);
                Console.WriteLine(b);
                Console.WriteLine(a);
                return;
            }
        }
    }
}
