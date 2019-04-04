using System;

namespace Rectangle_Area
{
    class Program
    {
        static double Area(double height, double width)
        {

            return height * width;
        }
        static void Main(string[] args)
        {
           double height = double.Parse(Console.ReadLine());
           double width = double.Parse(Console.ReadLine());
            double area = Area(height, width);
            Console.WriteLine(area);
        }
    }
}
