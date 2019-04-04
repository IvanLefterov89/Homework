using System;

namespace DataType
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int valueInt;
            float valueFloat;
            char valueChar;
            bool valueBool;
            while (data != "END")
            {
                if (int.TryParse(data, out valueInt)) // Проверява дали стринга data съдържа стойност от тип Инт в променливата valueInt
                {
                    Console.Write($"{data} is integer type");
                    Console.WriteLine();
                }
                else if (float.TryParse(data, out valueFloat))
                {
                    Console.Write($"{data} is floating point type");
                    Console.WriteLine();
                }
                else if (char.TryParse(data, out valueChar))
                {
                    Console.Write($"{data} is character type");
                    Console.WriteLine();
                }
                else if (bool.TryParse(data, out valueBool))
                {
                    Console.Write($"{data} is boolean type");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{data} is string type");
                    
                }
                data = Console.ReadLine();
            }
        }
    }
}
