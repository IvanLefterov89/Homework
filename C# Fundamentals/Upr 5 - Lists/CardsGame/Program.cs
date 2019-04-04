using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> Player1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> Player2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (Player1.Count > 0 || Player2.Count > 0)
            {
                if (Player1[0] == Player2[0])
                {
                    Player1.RemoveAt(0);
                    Player2.RemoveAt(0);
                }
                else if (Player1[0] > Player2[0])
                {
                    Player1.Add(Player1[0]);
                    Player1.Add(Player2[0]);
                    Player1.RemoveAt(0);
                    Player2.RemoveAt(0);
                }
                else if (Player1[0] < Player2[0])
                {
                    Player2.Add(Player2[0]);
                    Player2.Add(Player1[0]);
                    Player2.RemoveAt(0);
                    Player1.RemoveAt(0);
                }
                if (Player1.Count == 0 || Player2.Count == 0)
                {
                    break;
                }

            }
            if (Player1.Sum() > Player2.Sum())
            {
                Console.WriteLine($"First player wins! Sum: {Player1.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {Player2.Sum()}");
            }
        }
    }
}
