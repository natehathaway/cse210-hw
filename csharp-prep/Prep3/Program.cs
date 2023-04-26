using System;

namespace Prep3
{
    public class Program
    {
        static void Main(string[] args)
        {
            string game = "y";
            string loop = "y";
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);
            Console.WriteLine("Welcome to the Number Guessing Game!");
            int guessCount = 0;
            do
            {
                Console.WriteLine("What is your guess?");
                int guess = int.Parse(Console.ReadLine());
                guessCount++;
                if (guess == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                    loop = "n";
                    Console.WriteLine("Would you like to play again? (y/n)");
                    game = Console.ReadLine();
                    if (game == "y")
                    {
                        magicNumber = randomGenerator.Next(1, 11);
                        guessCount = 0;
                        loop = "y";
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                    }
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                    loop = "y";
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                    loop = "y";
                }
            } while (loop == "y");
        }
    }
}