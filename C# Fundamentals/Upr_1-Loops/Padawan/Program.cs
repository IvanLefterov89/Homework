using System;

namespace Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students =int.Parse(Console.ReadLine());
            double lightsabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double freeBelts = students / 6;

            double total = (Math.Ceiling(students * 1.1) * lightsabrePrice) + (students * robePrice) + ((students * beltPrice - (Math.Floor(freeBelts)) * beltPrice));
            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else Console.WriteLine($"Ivan Cho will need {(total - money):F2}lv more.");
        }
    }
}
