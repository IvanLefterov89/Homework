using System;

namespace MathPower
{
    class Program
    {
        static double RaisePower(double a, int power)
        {
            double result = Math.Pow(a,power);
            
            return result;
            
        }
        static void Main(string[] args)
        {
            
            double a = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
         
            double result = Math.Pow(a,power);
            
               
            
            Console.WriteLine(result);
        }
    }
}
