using System;
using System.Text.RegularExpressions;

namespace SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-z][a-z]+)%[^|,$,%,.]*<(?<product>\w+)>[^|,$,%,.]*\|(?<count>\d+)\|[^|,$,%,.]*?(?<price>[0-9]+\.?[0-9]+)\$";
            string input = String.Empty;
            double totalIncome = 0.0;
            while ((input = Console.ReadLine())!="end of shift")
            {
                Regex order = new Regex(pattern);
                if (order.IsMatch(input))
                {
                    string customerName = order.Match(input).Groups["customer"].Value; // dobavqme imeto na klient ot expression-a
                    string productName = order.Match(input).Groups["product"].Value;
                    int count = int.Parse(order.Match(input).Groups["count"].Value);
                    double price = double.Parse(order.Match(input).Groups["price"].Value);

                    double totalPrice = price * count; // suma na konkreten produkt
                    totalIncome += totalPrice; // obshta suma
                    Console.WriteLine($"{customerName}: {productName} - {totalPrice:F2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
