using System;
using System.Text;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        List<string> history = new List<string>();
        int wins, losses, ties;

        public void PlayRound()
        {   
            int roundNum = wins + losses + ties + 1;
            Console.Write("Round " + roundNum + "! Rock, Paper, or Scissors? (r/p/s): ");
            string input = Console.ReadLine();
            string compMove = DecideMove();
            Console.WriteLine("Computer chose " + compMove);
            if(input == compMove)
            {
                Console.WriteLine("It's a tie!");
                ties++;
                history.Add(input + "\t" + compMove + "\tTie");
            }
            else if(input == "r" && compMove == "p")
            {
                Console.WriteLine("You lost! Rock loses to paper.");
                losses++;
                history.Add(input + "\t" + compMove + "\tLoss");
            }
            else if(input == "r" && compMove == "s")
            {
                Console.WriteLine("You win! Rock beats scissors.");
                wins++;
                history.Add(input + "\t" + compMove + "\tWin");
            }
            else if(input == "p" && compMove == "r")
            {
                Console.WriteLine("You win! Paper beats rock.");
                wins++;
                history.Add(input + "\t" + compMove + "\tWin");
            }
            else if(input == "p" && compMove == "s")
            {
                Console.WriteLine("You lost! Paper loses to scissors.");
                losses++;
                history.Add(input + "\t" + compMove + "\tLoss");
            }
            else if(input == "s" && compMove == "r")
            {
                Console.WriteLine("You lost! Scissors loses to rock.");
                losses++;
                history.Add(input + "\t" + compMove + "\tLoss");
            }
            else if(input == "s" && compMove == "p")
            {
                Console.WriteLine("You win! Scissors beats paper.");
                wins++;
                history.Add(input + "\t" + compMove + "\tWin");
            }
            else
            {
                Console.WriteLine("Please enter r/p/s to play a round.");
            }
        }

        string DecideMove()
        {
            Random random = new Random();
            String[] correspondingResults = {"r", "p", "s"};
            // For the computer, the results are a follows:
            // 0 = Rock
            // 1 = Paper
            // 2 = Scissors
            string randomMove = correspondingResults[random.Next(0,2)];
            return randomMove;
        }

        public void PrintSummary(){
            int rounds = wins + losses + ties;
            Console.WriteLine("You played " + rounds + " rounds. Here are the results.");
            Console.WriteLine("Wins " + wins + ", Losses " + losses + ", Ties " + ties);
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("|\tYou\tCP\tResult\t|");
            Console.WriteLine("*-------------------------------*");
            foreach(string record in history)
            {
                Console.WriteLine("|\t" + record + "\t|");
            }
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("Thank you for playing!");
        }
    }
}