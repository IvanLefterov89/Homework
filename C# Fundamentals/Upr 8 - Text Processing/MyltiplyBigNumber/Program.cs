using System;
using System.Numerics;
using System.Text;
using System.Linq;

namespace MyltiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigInt = Console.ReadLine();
           int[] bigInt1 = bigInt.Split().Select(int.Parse).ToArray();
           short smallInt = short.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            bool istrue = false;
            int count = 0;
            int multiply = 0;
            for (int i = bigInt1.Length - 1; i >= 0; i--)
            {
                if (bigInt.Length <= 7)
                {
                    int result = int.Parse(bigInt) * smallInt;
                    Console.WriteLine(result);
                    istrue = true;
                    break;
                }
                count++;
                multiply = bigInt1[i] * smallInt;
                sb.Append(Math.Pow((bigInt1[i - 1] * smallInt), count) + multiply);
            }
            if (!istrue)
            Console.WriteLine(sb);
            
        }
    }
}
