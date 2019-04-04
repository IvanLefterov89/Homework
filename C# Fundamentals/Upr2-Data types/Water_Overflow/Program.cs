using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < number; i++)
            {
                int litres = int.Parse(Console.ReadLine());

                if ((sum + litres) <= 255 && litres <= 255)
                {
                    sum += litres;
                }
                else Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(sum);

        }
    }
}
