using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheelsSong
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            int x = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            if (i < j && k > l && ((i * j) + (k * l) == a))
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                count++;
                                if (count == 4)
                                {
                                    x = i;
                                    b = j;
                                    c = k;
                                    d = l;
                                }
                            }
                            
                            
                        }
                    }
                }
            }
            Console.WriteLine();
            if (count >=4)
            Console.WriteLine($"Password: {x}{b}{c}{d} "); 
            if (count < 4)
            Console.WriteLine("No!");
        }
    }
}
