using System;

namespace Triangle
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            PrintTriangle(maxNumber);
            PrintReverseTriangle(maxNumber);

        }
        private static void PrintTriangle(int maxNumber)
        {
            for (int i = 1; i <= maxNumber; i++)
            {

                for (int j = 1; j <= i; j++)
                {

                    Console.Write(j + " ");
                }

                Console.WriteLine();

            }

        }

        private static void PrintReverseTriangle(int maxNumber)
        {
            for (int i = maxNumber; i >= 1; i--)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }


    }
}
