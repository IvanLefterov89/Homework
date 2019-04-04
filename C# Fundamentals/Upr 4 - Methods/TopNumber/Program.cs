using System;
using System.Linq;
namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                
                int sum = 0;
                if (i < 100)
                    sum = i / 10 + i % 10;
                if (i >= 100)
                    sum = i / 100 + ((i - (i/100)*100) / 10)%10 + i % 10;
                if (i >= 1000)
                    sum = i / 1000 + ((i - (i / 1000) * 1000) / 100) % 100 + ((i - (i / 100) * 100) / 10) % 10 + i % 10;
                //if (i >= 10000)
                //    sum = i / 10000 + ((i - (i / 10000) * 10000) / 1000) % 1000 + ((i - (i / 1000) * 1000) / 100) % 100 + ((i - (i / 100) * 100) / 10) % 10  + i % 10;
                if (sum % 8 == 0 && ((i % 10) % 2 == 1 || ((i - (i / 100) * 100) / 10) % 10 % 2 == 1))
                    Console.WriteLine(i);
              
            }
            
        }
    }
}
