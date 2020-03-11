using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    class RpsSmartStrategy : IRpsStrategy
    {
        public string DecideMove(string playerLastMove)
        {
            if (playerLastMove != null)
            {
                switch (playerLastMove)
                {
                    case "R":
                        return "P";
                    case "P":
                        return "S";
                    case "S":
                        return "R";
                }
            }
            return "R";
        }
    }
}
