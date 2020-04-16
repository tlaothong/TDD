using System;

namespace ch01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Number Master Mind!");
            Console.WriteLine("Please ENTER the 4-digit number: ");
            var answer = Console.ReadLine();

            Console.WriteLine("You must guess the right answer within 10 attempts");
            const int MaxAttempt = 10;

            for (int attemptCount = 0; attemptCount < MaxAttempt; attemptCount++)
            {
                Console.Write($"Guess #{attemptCount + 1}: ");
                var guess = Console.ReadLine();
                Console.WriteLine("Correct Numbers: x, Exact Correct: x");
                if (guess == answer)
                {
                    Console.WriteLine("This is the correct answer. You're the WINNER!");
                    return;
                }
            }

            Console.WriteLine("You're a LOSSER!");
        }
    }
}
