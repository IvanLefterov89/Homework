using System;
using System.Linq;
namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = 0;
            int sum1 = 0;
            bool istrue = true;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                sum += numbers[i];
                
                sum1 = 0;
                for (int j = 0; j <= numbers.Length - 1; j++)
                {                                        
                   
                    if (j - i > 0 && j + i <= numbers.Length+2)
                    { sum1 += numbers[j]; }                    
                }
                if ((sum - numbers[i]) == sum1)
                {
                    Console.WriteLine(i);
                    istrue = false;
                }
                

            }
            if (istrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}
