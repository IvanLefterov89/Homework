using System;
using System.Linq;
using System.Collections;
namespace EncryptNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofNames = int.Parse(Console.ReadLine());
            int[] names = new int[numberofNames];
            int encryption = 0;
            for (int i = 0; i < numberofNames; i++)
            {
                char[] encrypt = Console.ReadLine().ToCharArray();
                for (int j = 0; j <= encrypt.Length-1; j++)
                {
                    if (encrypt[j] == 'a' || encrypt[j] == 'e' || encrypt[j] == 'o' || encrypt[j] == 'i' || encrypt[j] == 'u' || encrypt[j] == 'A' || encrypt[j] == 'E' || encrypt[j] == 'O' || encrypt[j] == 'I' || encrypt[j] == 'U')
                    {
                        encryption += (char) encrypt[j] * encrypt.Length; 

                    }
                    else encryption += (char)encrypt[j] / encrypt.Length;
                }

                names[i] = encryption;
                encryption = 0;
                
            }
           names = names.OrderBy(x => x == 0).ThenBy(x => x).ToArray(); // Array order ascending
                foreach (var items in names)
            {
                Console.WriteLine(items);
            }
        }
    }
}
