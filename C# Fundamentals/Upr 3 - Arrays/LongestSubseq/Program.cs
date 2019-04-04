using System;
using System.Linq;
namespace LongestSubseq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] output = input.ToArray();
            int[] output2 = input.ToArray();
            string seq1 = "";
            
            for (int i = 0; i < input.Length - 1; i++)
            {
                string seq = "";
                int k = 0;
                for (int j = i; j <= input.Length - 1; j++)
                {
                    if (output[j] > input[i])
                    {
                       // if (output2[k] < output[j])
                       // {
                            seq += output[j] + " ";
                        //    k++;
                       // }
                    }
                    
                    
                }
                if (seq.Length > seq1.Length)
                {
                    seq1 = seq;
                }
              
            }
            Console.WriteLine(seq1);
          //  foreach (var item in output3)
          //  {
          //     Console.WriteLine(item + " ");
         //   }
        }
    }
}
