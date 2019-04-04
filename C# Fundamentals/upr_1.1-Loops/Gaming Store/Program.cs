using System;

namespace Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spent = 0;
            string game = Console.ReadLine();

            while (game != "Game Time")
            {
                switch (game)
                {
                    case "OutFall 4":
                        {
                             
                            if (balance >= 39.99)
                            {
                                balance = balance - 39.99;
                                spent = spent + 39.99;
                                Console.WriteLine("Bought OutFall 4");
                            }
                            else Console.WriteLine("Too Expensive");
                           
                            break;
                        }
                    case "CS: OG":
                        {
                           
                            if (balance >= 15.99)
                            {
                                balance = balance - 15.99;
                                spent = spent + 15.99;
                                Console.WriteLine("Bought CS: OG");
                            }
                            else Console.WriteLine("Too Expensive");
                           
                            break;
                        }
                    case "Zplinter Zell":
                        {
                            
                            if (balance >= 19.99)
                            {
                                balance = balance - 19.99;
                                spent = spent + 19.99;
                                Console.WriteLine("Bought Zplinter Zell");
                            }
                            else Console.WriteLine("Too Expensive");
                            
                            break;
                        }
                    case "Honored 2":
                        {
                            
                            if (balance >= 59.99)
                            {
                                balance = balance - 59.99;
                                spent = spent + 59.99;
                                Console.WriteLine("Bought Honored 2");
                            }
                            else Console.WriteLine("Too Expensive");
                            
                            break;
                        }
                    case "RoverWatch":
                        {
                            
                            if (balance >= 29.99)
                            {
                                balance = balance - 29.99;
                                spent = spent + 29.99;
                                Console.WriteLine("Bought RoverWatch");
                            }
                            else Console.WriteLine("Too Expensive");
                        
                            break;
                        }
                    case "RoverWatch Origins Edition":
                        {
                            
                            if (balance >= 39.99)
                            {
                                balance = balance - 39.99;
                                spent = spent + 39.99;
                                Console.WriteLine("Bought RoverWatch Origins Edition");
                            }
                            else Console.WriteLine("Too Expensive");
                            
                            break;
                        }
                    default: { Console.WriteLine("Not Found"); break; }
                }
                if (balance <= 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spent:F2}. Remaining: ${balance:F2}");
        }
    }
}
