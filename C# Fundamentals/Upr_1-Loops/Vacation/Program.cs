using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string person = Console.ReadLine();
            string day = Console.ReadLine();
            double newPrice = 0;
            double price = 0;
            switch (person)
            {
                case "Students":
                    {
                        if (day == "Friday")
                        {
                            newPrice = numberPeople * 8.45;
                            
                        }
                        if (day == "Saturday")
                        {
                            newPrice = numberPeople * 9.80;

                        }
                        if (day == "Sunday")
                        {
                            newPrice = numberPeople * 10.46;
                        }
                        if (numberPeople >= 30)
                        {
                            newPrice = newPrice * 0.85;
                        }
                        break;
                    }
                case "Business":
                    {
                        
                        if (day == "Friday")
                        {
                            price = 10.90;
                            newPrice = numberPeople * 10.90;

                        }
                        if (day == "Saturday")
                        {
                            price = 15.60;
                            newPrice = numberPeople * 15.60;

                        }
                        if (day == "Sunday")
                        {
                            price = 16;
                            newPrice = numberPeople * 16;
                        }

                        if (numberPeople >= 100)
                        {
                            newPrice = (numberPeople - 10) * price;
                        }
                        break;
                    }
                case "Regular":
                    {
                        if (day == "Friday")
                        {
                            newPrice = numberPeople * 15;

                        }
                        if (day == "Saturday")
                        {
                            newPrice = numberPeople * 20;

                        }
                        if (day == "Sunday")
                        {
                            newPrice = numberPeople * 22.50;
                        }
                        if (numberPeople >= 10 && numberPeople <= 20)
                        {
                            newPrice = 0.95 * newPrice;
                        }

                        break;
                    }

            }
            Console.WriteLine($"Total price: {newPrice:F2}");
        }
    }
}
