using System;

namespace Vending_Machine
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            while (input != "Start")
            {
                double value = double.Parse(input);

                if (value == 0.1 ||
                    value == 0.2 ||
                    value == 0.5 ||
                    value == 1 ||
                    value == 2)
                {
                    sum = sum + value;
                }
                else { Console.WriteLine($"Cannot accept {value}"); }

                input = Console.ReadLine();


            }
            input = Console.ReadLine();
            double itemPrice = 0;
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                        {
                            itemPrice = 2;
                            if (sum >= itemPrice)
                            {
                                Console.WriteLine("Purchased nuts");
                                sum = sum - itemPrice;
                            }
                            else { Console.WriteLine("Sorry, not enough money"); }
                            break;
                        }
                    case "Water":
                        {
                            itemPrice = 0.7;
                            if (sum >= itemPrice)
                            {
                                Console.WriteLine("Purchased water");
                                sum = sum - itemPrice;
                            }
                            else { Console.WriteLine("Sorry, not enough money"); }
                            break;
                        }
                    case "Crisps":
                        {
                            itemPrice = 1.5;
                            if (sum >= itemPrice)
                            {
                                Console.WriteLine("Purchased crisps");
                                sum = sum - itemPrice;
                            }
                            else { Console.WriteLine("Sorry, not enough money"); }
                            break;
                        }
                    case "Soda":
                        {
                            itemPrice = 0.8;
                            if (sum >= itemPrice)
                            {
                                Console.WriteLine("Purchased soda");
                                sum = sum - itemPrice;
                            }
                            else { Console.WriteLine("Sorry, not enough money"); }
                            break;
                        }
                    case "Coke":
                        {
                            itemPrice = 1;
                            if (sum >= itemPrice)
                            {
                                Console.WriteLine("Purchased coke");
                                sum = sum - itemPrice;
                            }
                            else { Console.WriteLine("Sorry, not enough money"); }
                            break;
                        }
                    default: { Console.WriteLine("Invalid product"); break; }
                       
                }
                input = Console.ReadLine();
            }
           Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
