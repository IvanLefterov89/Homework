using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> AllTimes = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> leftRacer = new List<int>();
            List<int> rightRacer = new List<int>();
            short count = 0;
            double sum = 0;
            double sum1 = 0;
            foreach (var time in AllTimes)
            {
                count++;
                if (count <= AllTimes.Count / 2)
                {
                    leftRacer.Add(time);
                }
                if (count > AllTimes.Count / 2 + 1)
                {
                    rightRacer.Add(time);
                }
            }
            rightRacer.Reverse();

            foreach (var item in leftRacer)
            {
                if (item != 0)
                {
                    sum = sum + item;
                }

                if (item == 0)
                {
                    sum = 0.8 * sum;
                }
            }
            foreach (var item in rightRacer)
            {
                if (item != 0)
                {
                    sum1 = sum1 + item;
                }

                if (item == 0)
                {
                    sum1 = 0.8 * sum1;
                }
            }
            if (sum < sum1)
            {
                Console.WriteLine($"The winner is left with total time: {sum}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sum1}");
            }
        }
    }
}
