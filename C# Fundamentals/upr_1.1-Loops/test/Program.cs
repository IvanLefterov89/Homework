using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double leftMoney = money;
            while (true)
            {
                if (money == 0)
                {
                    Console.WriteLine("Out of money!");

                    break;
                }
                string currentGame = Console.ReadLine();

                if (currentGame == "OutFall 4")
                {
                    if (money >= 39.99)
                    {
                        Console.WriteLine("Bought OutFall 4");
                        money -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "CS: GO")
                {
                    if (money >= 15.99)
                    {
                        Console.WriteLine("Bought CS: GO");
                        money -= 15.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "Zplinter Zell")
                {
                    if (money >= 19.99)
                    {
                        Console.WriteLine("Bought Zplinter Zell");
                        money -= 19.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "Honored 2")
                {
                    if (money >= 59.99)
                    {
                        Console.WriteLine("Bought Honored 2");
                        money -= 59.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "RoverWatch")
                {
                    if (money >= 29.99)
                    {
                        Console.WriteLine("Bought RoverWatch");
                        money -= 29.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "RoverWatch Origins Edition")
                {
                    if (money >= 39.99)
                    {
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                        money -= 39.99;
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (currentGame == "Game Time")
                {
                    Console.WriteLine($"Total spent: ${(leftMoney - money):f2}. Remaining: ${money:f2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Found");
                }
            }
        }
    }
}
