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
            Console.WriteLine($"You scored {Result}%");
        }
    }
}
