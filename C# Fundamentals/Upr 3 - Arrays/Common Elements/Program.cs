using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ');
            var number2 = Console.ReadLine().Split(' ');
            string[] firstArray = new string[10];
            string[] secondArray = new string[10];

            for (int i = 0; i <= number.Length - 1; i++)
            {
                var elements1 = number[i];

                firstArray[i] = elements1;


            }
                for (int j = 0; j <= number2.Length - 1; j++)
                {
                    var elements2 = number2[j];
                    secondArray[j] = elements2;

                    foreach (var elementsCompare in firstArray)
                    {
                        if (elements2 == elementsCompare)
                        {
                            Console.Write($"{elements2} ");
                        
                        }
                    }
                }
            
            
        }
    }
}
