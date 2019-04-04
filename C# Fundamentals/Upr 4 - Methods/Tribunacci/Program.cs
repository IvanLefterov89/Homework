using System;

namespace Tribunacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] tribonacci = new int[number];
            for (int i = 3; i <= number-1; i++)
            {
                tribonacci[0] = 1;
                tribonacci[1] = 1;
                tribonacci[2] = 2;
                tribonacci[i] += tribonacci[i - 3] + tribonacci[i - 2]+ tribonacci[i-1];
            }
            if (number == 3)
            {
                tribonacci[0] = 1;
                tribonacci[1] = 1;
                tribonacci[2] = 2;
            }
            if (number == 2)
            {
                tribonacci[0] = 1;
                tribonacci[1] = 1;               
            }
            if (number == 1)
            {
                tribonacci[0] = 1;
            }
            foreach (var item in tribonacci)
            {
                Console.Write(item + " ");
            }
        }
    }
}
