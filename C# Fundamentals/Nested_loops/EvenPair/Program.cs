using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPair
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
         //   int count = a-1;
          //  int count1 = b-1;
        
            for (int i = a; i <= a+c; i++)
            {
                
                for (int j = b; j <= b+d; j++)
                {

                    if ((((i % 2 == 0) || (i % 3 == 0) || (i%5==0)|| (i%7==0)) || ((j % 2 == 0) || (j % 3 == 0) || (j % 5 == 0) || (j % 7 == 0))) == false)
                                    { Console.WriteLine($"{i}{j} "); }
                   
                                                                                                    
                }
            }
            
        }
    }
}
