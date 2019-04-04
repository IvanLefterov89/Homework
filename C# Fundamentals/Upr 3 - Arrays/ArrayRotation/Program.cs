using System;
using System.Linq;
namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            string[] firstArray = new string[numbers.Length];
           

            for (int i = 0; i < rotations; i++)
            {
                int firstNumber = numbers[0];
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j+1];
                }
                numbers[numbers.Length - 1] = firstNumber;
            }
            Console.WriteLine(String.Join(" ", numbers)); // izvejdane na stoinostite na masiva
            
        }
    }
}
