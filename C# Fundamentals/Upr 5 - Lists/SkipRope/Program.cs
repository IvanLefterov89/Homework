using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numberArray = new List<int>();
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();
            List<string> stringArray = new List<string>();
            StringBuilder result = new StringBuilder();
            int compareInt;

            for (int i = 0; i <= input.Length-1; i++)
            {
                if (int.TryParse(input[i].ToString(), out compareInt))
                {
                    numberArray.Add(int.Parse(input[i].ToString()));
                  //  input = input.Remove(i,1).ToString();
                }
                else if (!int.TryParse(input[i].ToString(), out compareInt))
                {
                    stringArray.Add(input[i].ToString());
                   // input = input.Remove(i, 1).ToString();
                }
                
            }
            for (int i = 0; i <= numberArray.Count - 1; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numberArray[i]);
                }
                if (i % 2 != 0)
                {
                    skipList.Add(numberArray[i]);
                }

            }
            input = "";
            foreach (var item in stringArray)
            {
                input += item;
            }
            int indexForSkip = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                List<string> temp = new List<string>(stringArray);

                temp = temp.Skip(indexForSkip).Take(takeList[i]).ToList();
                
                result.Append(string.Join("", temp));

                indexForSkip += takeList[i] + skipList[i];
            }
            Console.WriteLine(result.ToString());
          
        }
    }
}
