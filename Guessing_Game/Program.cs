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
            Console.WriteLine("I'm thinking of a number between 0 and 100.");
            Console.WriteLine("Can you guess what it is?");
            PlayGame();
           
           
        }
        

        static void PlayGame()
        {
            Random random = new Random();
            int secretNumber = random.Next(0, 101);
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
            Console.Write("\nWould you like to play again? (yes or no): ");
            string input = Console.ReadLine()?.ToLower();
            if(input == "yes" ||input == "y")
            {
                PlayGame();
            }
            else
            {
                Console.WriteLine("\nThanks for playing!");
            }
        }
    }
}
