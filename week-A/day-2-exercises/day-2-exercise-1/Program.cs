using System;

namespace day_2_exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 1; j < 8-i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = 8-i; x <= 8; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
