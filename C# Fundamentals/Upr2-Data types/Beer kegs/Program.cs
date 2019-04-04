using System;

namespace Beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double maxVolume = 0;

            string BiggestKeg = "";
            for (int i = 0; i < number; i++)
            {
                string kegModel = Console.ReadLine();
                double rad = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * rad * rad * height;
               
                if (volume > maxVolume)
                {
                     maxVolume = volume;
                    BiggestKeg = kegModel;
                }
                
            }
            Console.WriteLine(BiggestKeg);
        }
    }
}
