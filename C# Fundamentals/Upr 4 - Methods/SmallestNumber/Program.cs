using System;

namespace SmallestNumber
{
    class Program
    {
        public static void Order(int a,int b, int c)
            {
            if (a <= b && b <= c)
            {
                Console.WriteLine(a);
            }
            if (a >= b && b >= c)
            {
                Console.WriteLine(c);
            }
            if (a >= b && b <= c)
            {
                Console.WriteLine(b);
            }

        }
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int min = -10000000;
            {
                if (min <= a)
                {
                    min = a;
                    
                }
                if (min >= b)
                {
                    min = b;
                }
                if (min >= c)
                {
                    min = c;
                }
                Console.WriteLine(min);
            }
        }
    }
}
