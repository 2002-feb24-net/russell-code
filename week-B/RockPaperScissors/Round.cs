namespace RockPaperScissors
{
    public class Round
    {
        static int wins = 0;
        static int losses = 0;
        static int ties = 0;
        string playersMove;
        string computersMove;
        string results;

        public Round(string pm, string cm, string res)
        {
            playersMove = pm;
            computersMove = cm;
            results = res;
            if(res == "Win")
            {
                wins++;
            }
            else if(res == "Loss")
            {
                losses++;
            }
            else if(res == "Tie")
            {
                ties++;
            }
        }
        
        public string toString()
        {
            return(playersMove + "\t" + computersMove + "\t" + results);
        }

        public static int[] getScores()
        {
            return new int[3]{wins, losses, ties};
        }
    }
}