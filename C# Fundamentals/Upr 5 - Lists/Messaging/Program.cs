using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<string> indexNumbers = Console.ReadLine().Split().ToList();
            string message = Console.ReadLine();
            //List<char> numbers = new List<char>();
            string outputMessage = "";
            for (int j = 0; j <= indexNumbers.Count - 1; j++)
            {
                int sum = 0;
                for (int l = 0; l <= indexNumbers[j].Length-1; l++)
                {
                    int number = int.Parse(indexNumbers[j][l].ToString());
                    sum += number;
                }
                if (sum < message.Length)
                {
                   outputMessage += message[sum];
                   message= message.Remove(sum, 1);
                }
              else if (sum >= message.Length)
                {
                    outputMessage += message[sum - message.Length];
                   message = message.Remove(sum - message.Length, 1);
                }
            }
            Console.WriteLine(outputMessage);

        }
    }
}
