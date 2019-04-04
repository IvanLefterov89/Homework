using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split(", ").ToList();
            int lenght = names.Count;
            for (int i = 0; i <= names.Count-1; i++)
            {
                if (names[i].Length < 3 || names[i].Length > 16)
                {
                    names.Remove(names[i]);
                    i--;
                }
                else if (names[i].Length >= 3 && names[i].Length <= 16)
                {
                    for (int j = 0; j <= names[i].Length-1; j++)
                    {
                        if (!char.IsLetterOrDigit(names[i][j]) && names[i][j] != '-' && names[i][j] != '_')
                        {
                            names.Remove(names[i]);
                            i--;
                            break;
                        }
                        
                    }
                }
            }
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
