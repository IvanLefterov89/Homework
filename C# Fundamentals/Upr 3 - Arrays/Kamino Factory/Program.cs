using System;
using System.Linq;
namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            int longestSubseq = -1;
            int longestSubindex = -1;
            int longestSubSum = -1;
            int indexoflongest = 0;
             int[] sequence = new int[lenght];

            string input = Console.ReadLine();
            int indexofseq = 1;
           // int indexoflongest = 0;
            while (input != "Clone them!")
            {
                int[] currentSeq = input
                    .Split('!',StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int Subseq = 0;
                int Subindex = -1;
                int SubSum = 0;
                int count = 0;
                for (int i = 0; i < lenght; i++)
                {
                    if (currentSeq[i] == 1)
                    {
                        count++;
                        SubSum++;
                        if (count > Subseq)
                        {
                            Subseq = count;
                            Subindex = i - count;
                        }
                    }
                    else
                    {                       
                        count = 0;
                    }
                }
                if (Subseq > longestSubseq)
                {
                    longestSubindex = Subindex;
                    longestSubseq = Subseq;
                    longestSubSum = SubSum;
                    indexoflongest = indexofseq;
                    sequence = currentSeq;
                }
               else if (Subseq == longestSubseq && longestSubindex > Subindex)
                {
                    longestSubindex = Subindex;
                    indexoflongest = indexofseq;
                    longestSubSum = SubSum;
                    sequence = currentSeq;
                }
                else if (Subseq == longestSubseq && longestSubindex == Subindex && longestSubSum < SubSum)
                {
                   
                    longestSubSum = SubSum;
                    sequence = currentSeq;
                    indexoflongest = indexofseq;
                }
                indexofseq++;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {indexoflongest} with sum: {longestSubSum}."); 
            Console.WriteLine(String.Join(" ", sequence));
        }
    }
}
