using System;

namespace DataTypes
{
    class Program
    {
        private static int IntType(int valueInt, string input)
        {
           
            int.TryParse(input, out valueInt);
            return valueInt * 2;
        }
        private static double DoubleType(double valueDouble, string input)
        {
          
            double.TryParse(input, out valueDouble);
            return valueDouble * 1.5;
        }
        
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            var input = "";
            int valueInt = 0;
            double valueDouble = 0;
            if (type == "int")
            {
                input = Console.ReadLine();
                Console.WriteLine(IntType(valueInt, input));
                
            }
            if (type == "real")
            {
                input = Console.ReadLine();
                Console.WriteLine($"{DoubleType(valueDouble, input):F2}");
            }
            if (type == "string")
            {
                input = Console.ReadLine();               
                Console.WriteLine($"${input}$");
            }
        }
    }
}
