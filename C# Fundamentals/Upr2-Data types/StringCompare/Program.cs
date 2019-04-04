using System;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            long leftNumber = 0;
            long rightNumber = 0;

            long sumDigits = 0;
            long sumDigits1 = 0;
            for (int i = 1; i <= numbers; i++)
            {
                string numberstoCompare = Console.ReadLine();
                for (int j = 0; j < numberstoCompare.Length - 1; j++)
                {
                    if (numberstoCompare[j].ToString() == " ")
                    {
                        leftNumber = long.Parse(numberstoCompare.Substring(0, j));
                        rightNumber = long.Parse(numberstoCompare.Substring(j, numberstoCompare.Length - j).Trim());

                        if (leftNumber > rightNumber)
                        {
                            sumDigits = 0;
                            for (int k = 0; k <= j; k++)
                            {
                                //
                                long lastDigit = leftNumber % 10;
                                sumDigits += lastDigit;
                                leftNumber = leftNumber / 10;
                            }
                            Console.WriteLine(sumDigits);
                        }
                        else if (leftNumber <= rightNumber)
                        {
                            sumDigits1 = 0;
                            for (int l = j+1; l <= numberstoCompare.Length - 1; l++)
                            {
                                // 
                                long lastDigit1 = rightNumber % 10;
                                sumDigits1 += lastDigit1;
                                rightNumber = rightNumber / 10;
                            }
                            Console.WriteLine(sumDigits1);
                        }

                    }

                }

            }

        }
    }
}
