using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your username: ");
            string UserName = Console.ReadLine();

            Console.WriteLine("Please enter your password: ");
            string Password = Console.ReadLine();

            if (UserName == "admin" && Password == "pass1234")
            {
                Console.WriteLine("Welcome!");
            }
            else if (UserName != "admin")
            {
                Console.WriteLine("Incorrect username.");
            }
            else if (Password != "pass1234")
            {
                Console.WriteLine("Incorrect password.");
            }
            else
            {
                Console.WriteLine("Please try again."); 
            }
        }
    }
}
