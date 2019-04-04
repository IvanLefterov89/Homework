using System;

namespace Multiply
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number == 0 || number1 == 0 || number2 == 0)
            {
                Console.WriteLine("zero");
                
            }
           if (number < 0)
            {
                if ((number1 < 0 && number2 < 0) || (number1 > 0 && number2 > 0))
                Console.WriteLine("negative");
                if (number1 < 0 && number2 > 0 || (number1 > 0 && number2 < 0))

                    Console.WriteLine("positive");
            }
            if (number > 0)
            {
                if ((number1 < 0 && number2 < 0) || (number1 > 0 && number2 > 0))
                    Console.WriteLine("positive");
                if (number1 < 0 && number2 > 0 || (number1 > 0 && number2 < 0))

                    Console.WriteLine("negative");
            }
        }
    }
}
