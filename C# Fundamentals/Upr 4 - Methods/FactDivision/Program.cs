using System;

namespace FactDivision
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
           long firstFact= GetFactorial(firstNumber);
            long secondFact = GetFactorial(lastNumber);

            double result = (double)firstFact / secondFact;
            Console.WriteLine($"{result:F2}");
        }
        private static long GetFactorial(long number)
        {
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
