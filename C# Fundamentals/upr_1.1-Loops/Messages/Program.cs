using System;

namespace Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberofLetters = int.Parse(Console.ReadLine());
            string message = "";
            char letter = ' ';
           
            for (int i = 1; i <= numberofLetters; i++)
            {
                int digitsTyped = int.Parse(Console.ReadLine());
                switch (digitsTyped)
                {
                    case 2:
                        {
                            letter = 'a';
                            message += letter;
                            break;
                        }
                    case 22:
                        {
                            letter = 'b';
                            message += letter;
                            break;
                        }
                    case 222:
                        {
                            letter = 'c';
                            message += letter;
                            break;
                        }
                    case 3:
                        {
                            letter = 'd';
                            message += letter;
                            break;
                        }
                    case 33:
                        {
                            letter = 'e';
                            message += letter;
                            break;
                        }
                    case 333:
                        {
                            letter = 'f';
                            message += letter;
                            break;
                        }
                    case 4:
                        {
                            letter = 'g';
                            message += letter;
                            break;
                        }
                    case 44:
                        {
                            letter = 'h';
                            message += letter;
                            break;
                        }
                    case 444:
                        {
                            letter = 'i';
                            message += letter;
                            break;
                        }
                    case 5:
                        {
                            letter = 'j';
                            message += letter;
                            break;
                        }
                    case 55:
                        {
                            letter = 'k';
                            message += letter;
                            break;
                        }
                    case 555:
                        {
                            letter = 'l';
                            message += letter;
                            break;
                        }
                    case 6:
                        {
                            letter = 'm';
                            message += letter;
                            break;
                        }
                    case 66:
                        {
                            letter = 'n';
                            message += letter;
                            break;
                        }
                    case 666:
                        {
                            letter = 'o';
                            message += letter;
                            break;
                        }
                    case 7:
                        {
                            letter = 'p';
                            message += letter;
                            break;
                        }
                    case 77:
                        {
                            letter = 'q';
                            message += letter;
                            break;
                        }
                    case 777:
                        {
                            letter = 'r';
                            message += letter;
                            break;
                        }
                    case 7777:
                        {
                            letter = 's';
                            message += letter;
                            break;
                        }
                    case 8:
                        {
                            letter = 't';
                            message += letter;
                            break;
                        }
                    case 88:
                        {
                            letter = 'u';
                            message += letter;
                            break;
                        }
                    case 888:
                        {
                            letter = 'v';
                            message += letter;
                            break;
                        }
                    case 9:
                        {
                            letter = 'w';
                            message += letter;
                            break;
                        }
                    case 99:
                        {
                            letter = 'x';
                            message += letter;
                            break;
                        }
                    case 999:
                        {
                            letter = 'y';
                            message += letter;
                            break;
                        }
                    case 9999:
                        {
                            letter = 'z';
                            message += letter;
                            break;
                        }
                    case 0:
                        {
                            letter = ' ';
                            message += letter;
                            break;
                        }
                }
            }
            Console.WriteLine(message);
        }
    }
}
