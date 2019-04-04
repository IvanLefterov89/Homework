using System;

namespace Strong_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string StrongNumber = Console.ReadLine();
            int digit = 0;
            int fact = 1;
            int sumFact = 0;
            for (int i = 0; i < StrongNumber.Length; i++)
            {
                fact = 1;
                digit = int.Parse(StrongNumber[i].ToString());
                for (int j = 1; j <= digit; j++)
                {
                    fact = fact * j;
                }
                sumFact = sumFact + fact;
            }
            if (sumFact == int.Parse(StrongNumber))
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
