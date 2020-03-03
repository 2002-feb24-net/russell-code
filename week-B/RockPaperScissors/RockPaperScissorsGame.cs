using System;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        int wins, losses, ties;

        public void PlayRound()
        {
            Console.Write("Rock, Paper, or Scissors? (r/p/s): ");
            string input = Console.ReadLine();
            Random random = new Random();
            String[] correspondingResults = {"r", "p", "s"};
            // For the computer, the results are a follows:
            // 0 = Rock
            // 1 = Paper
            // 2 = Scissors
            string randomInput = correspondingResults[random.Next(0,2)];
            if(input == randomInput)
            {
                Console.WriteLine("It's a tie!");
                ties++;
            }
            else if(input == "r" && randomInput == "p")
            {
                Console.WriteLine("You lost! Rock loses to paper.");
                losses++;
            }
            else if(input == "r" && randomInput == "s")
            {
                Console.WriteLine("You win! Rock beats scissors.");
                wins++;
            }
            else if(input == "p" && randomInput == "r")
            {
                Console.WriteLine("You win! Paper beats rock.");
                wins++;
            }
            else if(input == "p" && randomInput == "s")
            {
                Console.WriteLine("You lost! Paper loses to scissors.");
                losses++;
            }
            else if(input == "s" && randomInput == "r")
            {
                Console.WriteLine("You lost! Scissors loses to rock.");
                losses++;
            }
            else if(input == "s" && randomInput == "p")
            {
                Console.WriteLine("You win! Scissors beats paper.");
                wins++;
            }
            else
            {
                Console.WriteLine("Please enter r/p/s to play a round.");
            }
        }

        public void PrintSummary(){
            Console.WriteLine("Here are the results.\nWins " + wins + ", Losses "
                + losses + ", Ties " + ties + "\nThank you for playing!");
        }
    }
}