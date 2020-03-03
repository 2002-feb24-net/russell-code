using System;

namespace day_2_exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            int seqNum = int.Parse(input);

            while(seqNum > 1)
            {
                Console.WriteLine(seqNum);
                if(seqNum % 2 == 0)
                {
                    seqNum /= 2;
                }
                else
                {
                    seqNum = seqNum * 3 + 1;
                }
            }
            Console.WriteLine(seqNum);
        }
    }
}
