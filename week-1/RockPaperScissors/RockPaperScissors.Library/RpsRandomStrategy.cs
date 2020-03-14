using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public class RpsRandomStrategy : IRpsStrategy
    {
        public string DecideMove(string playerLastMove)
        {
            Random random = new Random();
            String[] correspondingResults = { "R", "P", "S" };
            // For the computer, the results are a follows:
            // 0 = Rock
            // 1 = Paper
            // 2 = Scissors
            return correspondingResults[random.Next(0, 3)];
        }
    }
}
