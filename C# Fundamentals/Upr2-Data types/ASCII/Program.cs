using System;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int begin = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            string symbol = "";
          
            for (int i = begin; i <= end; i++)
            {
                 symbol = Char.ConvertFromUtf32(i);
                Console.Write($"{symbol} ");
              
            }
            
        }
    }
}
