using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            short[] SpecialNumberAndPower = Console.ReadLine().Split().Select(short.Parse).ToArray();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == SpecialNumberAndPower[0])
                {

                    if (i - SpecialNumberAndPower[1] >= 0 && i + SpecialNumberAndPower[1] <= numbers.Count - 1)
                    {
                        numbers.RemoveRange(i - SpecialNumberAndPower[1], SpecialNumberAndPower[1] * 2 + 1);
                        i = 0;
                    }
                    else if (i - SpecialNumberAndPower[1] < 0 && i + SpecialNumberAndPower[1] > numbers.Count - 1)
                    {
                        numbers.RemoveRange(0, numbers.Count);
                        i = 0;


                    }
                    else if (i - SpecialNumberAndPower[1] >= 0)
                    {
                        numbers.RemoveRange(i - SpecialNumberAndPower[1], SpecialNumberAndPower[1] - i + numbers.Count);
                        i = 0;
                    }
                 

                    else if (i - SpecialNumberAndPower[1] < 0)
                    {
                        numbers.RemoveRange(0, i);
                        numbers.RemoveRange(0, SpecialNumberAndPower[1] + 1);
                        // i = (SpecialNumberAndPower[1] - 1 + numbers.Count) - i;
                        i = 0;
                    }


                }

            }
            Console.WriteLine(numbers.Sum());
        }
    }
}
