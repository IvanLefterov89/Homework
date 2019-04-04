using System;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine().Split(' ');
          
            
            for (int i=0; i<number.Length/2;i++)
            {
              var oldelement= number[i];
              number[i]=  number[number.Length - 1 - i];
                number[number.Length - 1 - i] = oldelement;         
            }
            Console.Write($"{string.Join(" ", number)}");

        }
    }
}
