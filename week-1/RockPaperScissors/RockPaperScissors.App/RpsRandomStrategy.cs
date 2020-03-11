using RockPaperScissors.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.App
{
    class RpsRandomStrategy : IRpsStrategy
    {
        public string DecideMove(string playerLastMove)
        {
            Random random = new Random();
            String[] correspondingResults = { "R", "P", "S" };
            // For the computer, the results are a follows:
            // 0 = Rock
            // 1 = Paper
            // 2 = Scissors
            string randomMove = correspondingResults[random.Next(0, 2)];
            return randomMove;
        }
    }
}
