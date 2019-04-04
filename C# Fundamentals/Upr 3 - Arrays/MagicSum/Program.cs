using System;
using System.Collections;
using System.Linq;
namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int magicSum = int.Parse(Console.ReadLine());
            int[] numbers1 = numbers.ToArray();
            string seq = string.Empty;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
               
                for (int j = i+1; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] + numbers1[j] == magicSum)
                    {
                          seq = seq + numbers[i] + " " + numbers1[j] + "|";
                                                                
                    }
                }            
                
            }
            string[] firstArray = seq.Trim().Split("|").Where(x => !string.IsNullOrEmpty(x)).ToArray();

            foreach (var item in firstArray)
            {

                Console.WriteLine(item);
            }
        }
    }
}
