using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrays = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> list1 = arrays.ToList();
            string[] list2 = new string[list1.Count];
            for (int i = 0; i <= list1.Count - 1; i++)
            {             
               var element = list1[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j <= element.Length - 1; j++)
                {
                    list2[i] += element[j] + " ";
                }
            }
            for (int i = list2.Length-1; i>=0;i--)
            {
                Console.Write(list2[i]);
            }
        }
    }
}
