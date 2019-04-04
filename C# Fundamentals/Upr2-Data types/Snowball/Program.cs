using System;

namespace Snowball
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowballs = int.Parse(Console.ReadLine());
       
            
            double snowballValue1 = 0;
            int snowballSnow1 = 0;
           int snowballTime1 = 0;
            int snowballQuality1 = 0;
            double snowballValue = 0;
            for (int i = 1; i <= numberSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                 int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                if (snowballTime != 0)
                {
                     snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);
                }
                if (snowballValue > snowballValue1)
                {
                    snowballValue1 = snowballValue;
                    snowballSnow1 = snowballSnow;
                    snowballTime1 = snowballTime;
                    snowballQuality1 = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnow1} : {snowballTime1} = {snowballValue1} ({snowballQuality1})");
        }
    }
}
