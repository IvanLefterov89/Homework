using System;

namespace Calculations
{
    class Program
    {
        private static void add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        private static void subtract(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        private static void multiply(double a, double b)
        {
            Console.WriteLine(a * b);
        }
        private static void divide(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void Main(string[] args)
            {
            string method = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
           
            switch (method)
            {
                case "add":
                    {
                        add(a,b);
                        break;
                    }
                case "subtract":
                    {
                        subtract(a, b);
                        break;
                    }
                case "multiply":
                    {
                        multiply(a, b);
                        break;
                    }
                case "divide":
                    {
                        divide(a, b);
                        break;
                    }
            }
           // Console.WriteLine(c);
            }
    }
}
