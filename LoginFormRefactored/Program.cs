using System;

namespace LoginFormRefactored
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName, Password;
            Console.WriteLine("Enter your username:");
            UserName = Console.ReadLine();

            Console.WriteLine("Enter your password:");
            Password = Console.ReadLine();

            if (UserName == "admin" && Password == "pass1234")
            {
                Console.WriteLine("Welcome, admin!");
            }
            else
            {
                Console.WriteLine("Try again.");
            }
        }
    }
}
