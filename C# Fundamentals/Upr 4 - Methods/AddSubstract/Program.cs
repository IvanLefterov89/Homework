using System;

namespace AddSubstract
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            SubtractSum(firstNumber, secondNumber, thirdNumber);
        }

        private static void SubtractSum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int sumofnumbers = firstNumber + secondNumber - thirdNumber;
            Console.WriteLine(sumofnumbers);
        }
        
    }
}
