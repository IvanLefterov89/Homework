using System;

namespace CharacterInRange
{
    class Program
    {
        private static void PrintCharacter(char firstSymbol, char lastSymbol)
        {
            if (firstSymbol < lastSymbol)
                for (char i = firstSymbol; i < lastSymbol; i++)
                {
                    if (i != firstSymbol)
                        Console.Write(i + " ");
                }
            if (firstSymbol > lastSymbol)
                for (char i = lastSymbol; i < firstSymbol; i++)
                {
                    if (i != lastSymbol)
                        Console.Write(i + " ");
                }
        }
        static void Main(string[] args)
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char lastSymbol = char.Parse(Console.ReadLine());
            PrintCharacter(firstSymbol, lastSymbol);
           
        }
    }
}
