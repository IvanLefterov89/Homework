using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int N1 = N;
            int target = 0;
            int count = 0;
            while (N >= M)
            {
                count++;
                target = N - M;
                N -= M;
                if (N == 0.5 * N1)
                {
                    if (Y != 0)
                    {
                        target = (int)N / Y;                       
                        //Math.Floor(target);
                        break;
                    }
                }               
                

            }
            Console.WriteLine(target);
            Console.WriteLine(count);

        }
    }
}
