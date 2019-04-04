using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = begin; i <= end; i++)
            {
                for (int k = begin; k <= end; k++)
                {
                    count++;
                    if (i + k == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {k} = {i + k})");

                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
        }
    }
    }

