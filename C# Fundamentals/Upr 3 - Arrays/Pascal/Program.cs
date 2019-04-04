using System;

namespace Pascal
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[,] TwoDArray = new int[number,number];
            if (number == 1)
            {
                TwoDArray[0, 0] = 1;
            }
            for (int i = 1; i <= number - 1; i++)
            {
                TwoDArray[0,0] = 1;
                TwoDArray[i,0] = 1;
                for (int j = 1; j <= number - 1; j++)
                {
                    TwoDArray[i, j] = TwoDArray[i-1,j-1] + TwoDArray[i - 1, j];
                }
             }
            for (int i = 0; i < TwoDArray.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDArray.GetLength(1); j++)
                {
                    if (TwoDArray[i,j]!=0)
                    Console.Write(TwoDArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
        
    }
}
