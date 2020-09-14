using System;

namespace PrecentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Maximum;
            int UserScore;
            double Result;

            Console.WriteLine("What is your maximum score?");
            Maximum = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What is your score?");
            UserScore = Int32.Parse(Console.ReadLine());

            Result = ((UserScore * 100) / Maximum);

            if (Result >= 90)
            {
                Console.WriteLine("Your grade is 5");
            }
            else if (Result >= 80)
            {
                Console.WriteLine("Your grade is 4");
            }
            else if (Result >= 61)
            {
                Console.WriteLine("Your grade is 3");
            }
            else
            {
                Console.WriteLine("Your grade is 2");
            }

        }
    }
}
