using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            long[] fibonacci = new long[number];
            
                if (number == 1)
                {
                    Console.WriteLine(1);
                }
                if (number == 2)
                {
                    Console.WriteLine(1);
                }
                else
                {
                    for (int i = 2; i <= fibonacci.Length - 1; i++)
                    {
                        fibonacci[0] = 1;
                        fibonacci[1] = 1;
                        fibonacci[i] += fibonacci[i - 2] + fibonacci[i - 1];

                    }
                    Console.WriteLine(fibonacci[number - 1]);
                }
            
        }
    }
}
