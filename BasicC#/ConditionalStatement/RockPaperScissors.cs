using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_.ConditionalStatement
{
    internal class RockPaperScissors
    {
        /*
         * 7 Implement a simple rock, paper, scissors game in C#. 
         * Prompt the user to enter their choice, and use conditional statements to determine the winner based on the game rules 
         * (rock beats scissors, scissors beat paper, paper beats rock).
         */

        public static void rockPaperScissors()
        {
            Console.Write("Enter your choice (rock, paper, scissors): ");
            string userChoice = Console.ReadLine().ToLower();

            var random = new Random();

            string[] choices = { "rock", "paper", "scissors" };

            string computerChoice = choices[random.Next(choices.Length)];

            Console.WriteLine($"Computer chose: {computerChoice}");

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "scissors" && computerChoice == "paper") ||
                     (userChoice == "paper" && computerChoice == "rock"))
            {
                Console.WriteLine("You win!");
            }
            else if ((computerChoice == "rock" && userChoice == "scissors") ||
                     (computerChoice == "scissors" && userChoice == "paper") ||
                     (computerChoice == "paper" && userChoice == "rock"))
            {
                Console.WriteLine("Computer wins!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter rock, paper, or scissors.");
            }
        }
    }
}
