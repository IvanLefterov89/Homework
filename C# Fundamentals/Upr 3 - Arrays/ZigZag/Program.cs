using System;

namespace ZigZag
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] firstArray = new string[number];
            string[] secondArray = new string[number];
            for (int i = 0; i < number; i++)
            {
                var numbers = Console.ReadLine().Split(' ');
                if (i % 2 == 0)
                {
                    firstArray[i] += numbers[0];
                    secondArray[i] += numbers[1];
                }
                else
                {
                 firstArray[i] += numbers[1];
                 secondArray[i] += numbers[0];
                }
            }
            foreach (var element in firstArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            foreach (var element in secondArray)
            {
                Console.Write(element + " ");
            }
        }
    }
}
