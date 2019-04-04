using System;
using System.Linq;
namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string sequence = "";
            
            for (int i=0; i<=numbers.Length-1; i++)
            {
                if (i>0 && numbers[i-1] == numbers[i])
                {
                    sequence = sequence + " " + numbers[i - 1];
                    if (i< numbers.Length-1 && numbers[i] != numbers[i + 1])
                    {
                        sequence = sequence + " " + numbers[i] + "|";
                    }
                   
                }
                if(i == numbers.Length-1 && numbers[i - 1] == numbers[i])
                {
                    sequence = sequence + " " + numbers[i - 1];
                }
                }
            string[] firstArray = sequence.Trim().Split("|");
            string longsequence2 = string.Empty;
            for (int j = 0; j <= firstArray.Length - 1; j++)
            {
                if (firstArray[j].Trim().Length > longsequence2.Length)
                {
                    longsequence2 = firstArray[j];
                }
             
            }
            Console.WriteLine(longsequence2.Trim());

        }
    }
}
