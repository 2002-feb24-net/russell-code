using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();
            bool readyToQuit = false;
            while(!readyToQuit)
            {
                Console.Write("Do you want to play a round? (y/n): ");
                String input = Console.ReadLine();

                if(input == "n")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound();
                    // That method should play a round and print the result.
                }
            }
            game.PrintSummary();
            // That method should print out a summary of the rounds.
            // Including: how many wins, how many losses
        }
    }
}
