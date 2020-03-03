using System;

namespace day_2_exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int size = int.Parse(input);
            for (int i = 0; i < size; i++)
            {
                for (int j = 1; j < size-i; j++)
                {
                    Console.Write(" ");
                }
                for (int x = size-i; x <= size; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
