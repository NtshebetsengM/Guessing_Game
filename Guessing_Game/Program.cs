using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the guessing game!");
          ChooseDifficulty();
          
        }
        
        static void ChooseDifficulty()
        {
            Console.WriteLine("choose your difficulty!: easy, medium or hard");
            string difficulty = Console.ReadLine()?.ToLower();
            if (difficulty == "easy")
            {
                Console.WriteLine("I'm thinking of a number between 0 and 10");
                PlayGame(0, 10);
            }
            else if (difficulty == "medium")
            {
                Console.WriteLine("I'm thinking of a number between 0 and 100");
                PlayGame(0, 100);
            }
            else if (difficulty == "hard")
            {
                Console.WriteLine("I'm thinking of a number between 0 and 1000");
                PlayGame(0, 1000);
            }
            else
            {
                Console.WriteLine("Invalid choice! Starting with Medium mode.");
                PlayGame(0, 100);
            }
        }
        static void PlayGame(int min, int max)
        {
            Random random = new Random();
            int secretNumber = random.Next(min, max + 1);
            int guess = 0;
            int attempts = 0;

            while (guess != secretNumber)
            {
                Console.Write("\nWhats your guess?: ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        Console.WriteLine($"\nYipee! The number was {secretNumber}.");
                        Console.WriteLine($"You guessed it in {attempts} attempts.");
                        
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid input. Please enter a number.");
                }
            }

            
            PlayAgain();
        }
        static void PlayAgain()
        {
            Console.Write("\nWanna try your luck again? (yes or no): ");
            string input = Console.ReadLine()?.ToLower();
            if(input == "yes" ||input == "y")
            {
                Console.WriteLine("lets do it!");
                ChooseDifficulty();
            }
            else
            {
                Console.WriteLine("\nNext time!\nThanks for playing!");
            }
        }
    }
}
