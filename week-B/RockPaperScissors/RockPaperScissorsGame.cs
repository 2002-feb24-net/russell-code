using System;
using System.Text;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        List<Round> history = new List<Round>();
        int wins, losses, ties;

        public void PlayRound()
        {   
            int roundNum = history.Count + 1;
            Console.Write("Round " + roundNum + "! Rock, Paper, or Scissors? (r/p/s): ");
            string input = Console.ReadLine();
            string compMove = DecideMove();
            Console.WriteLine("Computer chose " + compMove);
            if(input == compMove)
            {
                Console.WriteLine("It's a tie!");
                history.Add(new Round(input, compMove, "Tie"));
            }
            else if(input == "r")
            {
                if(compMove == "s")
                {
                    Console.WriteLine("You win! Rock beats scissors.");
                    history.Add(new Round(input, compMove, "Win"));
                }
                else
                {
                    Console.WriteLine("You lost! Rock loses to paper.");
                    history.Add(new Round(input, compMove, "Loss"));
                }
            }
            else if(input == "p")
            {
                if(compMove == "r")
                {
                    Console.WriteLine("You win! Paper beats rock.");
                    history.Add(new Round(input, compMove, "Win"));
                }
                else
                {
                    Console.WriteLine("You lost! Paper loses to scissors.");
                    history.Add(new Round(input, compMove, "Loss"));
                }
            }
            else if(input == "s")
            {
                if(compMove == "p")
                {
                    Console.WriteLine("You win! Scissors beats paper.");
                    history.Add(new Round(input, compMove, "Win"));
                }
                else
                {
                    Console.WriteLine("You lost! Scissors loses to rock.");
                    history.Add(new Round(input, compMove, "Loss"));
                }
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
            Console.WriteLine("You played " + history.Count + " rounds. Here are the results.");
            int[] scores = Round.getScores();
            Console.WriteLine("Wins " + scores[0] + ", Losses " + scores[1] + ", Ties " + scores[2]);
            if(scores[0] == scores[1])
            {
                Console.WriteLine("The game's a tie!");
            }
            else if(scores[0] > scores[1])
            {
                Console.WriteLine("You are the winner!");
            }
            else
            {
                Console.WriteLine("You lose! You win nothing! Good day, sir!");
            }
            Console.WriteLine("*-------------------------------*");
            Console.WriteLine("|\tYou\tCP\tResult\t|");
            Console.WriteLine("*-------------------------------*");
            foreach(Round record in history)
            {
                Console.WriteLine("|\t" + record.toString() + "\t|");
            }
            Console.WriteLine("*-------------------------------*");
            int winner = Math.Max(scores[0], scores[1]);
            Console.WriteLine("Thank you for playing!");
        }
    }
}