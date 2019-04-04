using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string currentPassword = Console.ReadLine();
            int invalidPasswordAttempts = 1;
            while (currentPassword != password)
            {
                if (invalidPasswordAttempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPassword = Console.ReadLine();
                
               
                invalidPasswordAttempts++;
            }
            
                Console.WriteLine($"User {username} logged in.");
           
        }
    }
}
