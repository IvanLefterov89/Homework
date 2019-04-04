using System;
using System.Linq;
using System.Collections;
namespace Folding
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = int.Parse(Console.ReadLine());
            short[] input = Console.ReadLine().Split().Select(short.Parse).ToArray();
            int[] output = new int[input.Length/2];
            int[] output2 = new int[input.Length/2];
            short k = 0;
            short l = 0;
            for (short i = 0; i <= input.Length - 1; i++)
            {
                if (i+1 <= input.Length / 4 )
                {                   
                        output[input.Length / 4 - i-1] = input[l];
                    l++;
                }
                if (i + 1 > input.Length * 3 / 4)
                {
                    output[l] = input[input.Length * 7 / 4 - (i + 1)];
                    l++;
                }
                else if (i + 1 > input.Length / 4 && i + 1 <= input.Length * 3 / 4)
                {
                    output2[k] = input[i];
                    k++;
                }
            }
        
            for (short j = 0; j <= output.Length - 1; j++)
            {
                output[j] = output[j] + output2[j]; 
            }
            foreach (var item in output)
            {
                Console.Write(item + " ");
            }
        }
    }
}
