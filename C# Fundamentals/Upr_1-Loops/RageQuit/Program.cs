using System;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCounter = 0;
            int mouseCounter = 0;
            int keyboardCounter = 0;
            int displayCounter = 0;
            double sum = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetCounter++;
                }
                if (i % 3 == 0)
                {
                    mouseCounter++;
                }
                if (i % 6 == 0)
                {
                    keyboardCounter++;
                }
                if (i % 12 == 0)
                {
                    displayCounter++;
                }
            }
            sum = (headsetPrice * headsetCounter) + (mousePrice * mouseCounter) + (keyboardPrice * keyboardCounter) + (displayPrice * displayCounter);
            Console.WriteLine($"Rage expenses: {sum:F2} lv.");
        }
    }
}
