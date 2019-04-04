using System;

namespace Orders
{
    internal class Program
    {
        private static void Coffee(double price, int quantity)
        {
            price = 1.50;
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{price * quantity:F2}");
        }
        private static void Water(double price, int quantity)
        {
            price = 1.00;
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{price * quantity:F2}");
        }
        private static void Coke(double price, int quantity)
        {
            price = 1.40;
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{price * quantity:F2}");
        }
        private static void Snacks(double price, int quantity)
        {
            price = 2.00;
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine($"{price * quantity:F2}");
        }

        private static void Main(string[] args)
        {
            string method = Console.ReadLine();
            double price = 0;
            int quantity = 0;
            switch (method)
            {
                case "coffee":
                    {
                        Coffee(price, quantity);
                        break;
                    }
                case "water":
                    {
                        Water(price, quantity);
                        break;
                    }
                case "coke":
                    {
                        Coke(price, quantity);
                        break;
                    }
                case "snacks":
                    {
                        Snacks(price, quantity);
                        break;
                    }
            }
        }
    }
}
