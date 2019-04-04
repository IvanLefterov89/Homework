using System;

namespace Repeat_String
{
    class Program
    {
        private static void NewString (string repeat, int n)
        {

            string result = "";
                                   
                result += repeat;
           

        }
        static void Main(string[] args)
        {
           string repeat = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = 0; i < n; i++)
            {
                result += repeat;
            }
            

            Console.WriteLine(result);
        }
    }
}
