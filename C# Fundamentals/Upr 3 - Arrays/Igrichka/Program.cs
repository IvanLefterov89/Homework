using System;

namespace Igrichka
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] passangers = new int[number];
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                passangers[i] = numbers;
                Console.Write(passangers[i] + " ");
                sum += numbers;
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
