using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors.Library
{
    public interface IRpsStrategy
    {
        string DecideMove(string playerLastMove);
    }
}
