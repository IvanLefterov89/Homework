using System;

namespace PasswordValidate
{
    internal class Program
    {
        private static bool StringLenghtChecker(string inputPassword)
        {
            if (inputPassword.Length >= 6 && inputPassword.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static bool StringCharsChecker(string inputPassword)
        {
            for (int i = 0; i <= inputPassword.Length-1; i++)
            {
                if (!char.IsLetterOrDigit(inputPassword[i]))
                {
                    return false;
                }

            }
            return true;
                
        }
        private static bool StringDigitChecker(string inputPassword)
        {
            int count = 0;
            for (int i = 0; i < inputPassword.Length; i++)
            {
                if (char.IsDigit(inputPassword[i]))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else return false;
        }
        private static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            bool IsBetweenSixAndTen = StringLenghtChecker(inputPassword);
            bool isOnlyLettersAndDigits = StringCharsChecker(inputPassword);
            bool atLeastTwoDigits = StringDigitChecker(inputPassword);

            if (!IsBetweenSixAndTen)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!atLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (IsBetweenSixAndTen && isOnlyLettersAndDigits && atLeastTwoDigits)
            { Console.WriteLine("Password is valid"); }
        }

        
    }
}