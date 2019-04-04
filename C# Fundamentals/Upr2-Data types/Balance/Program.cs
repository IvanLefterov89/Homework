using System;

namespace Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string input = "";
           // string input1 = "";
            int j = -3;
            bool balance = false;
            int count = 0;
            int count1 = 0;
            int count2 = 0;
            for (int i = 1; i <= lines; i++)
            {
                
                input = Console.ReadLine();
                if (input == "(")
                {
                    j = i;                 
                    count++;
                    
                }
                if ((input == ")") )
                { if (j == i - 2)
                    { balance = true;
                        count1++; }
                    else balance = false;
                    count2++;
                }

            }
            if (balance && count == count1 && count1 == count2)
            {
                Console.WriteLine("BALANCED");
            }
            else Console.WriteLine("UNBALANCED");
        }
    }
}
