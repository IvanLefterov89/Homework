using System;

namespace FloatingEquality
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
           
                if (Math.Abs(a - b) >= (decimal)0.000001)
                {
                    Console.WriteLine("False");
                }
                else if (Math.Abs(a - b) < (decimal)0.000001)
                    Console.WriteLine("True");
            
            
        }
    }
}
