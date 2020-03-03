using System;

namespace day_5_exercise_acronym
{
    class Program
    {
        static void Main(string[] args)
        {
            string myWords = GetInput("Please input a multi-word term: ");
            PrintAcronym(myWords);
        }
        static string GetInput(string msg)
        {
            Console.Write(msg);
            string input = Console.ReadLine();
            return input;
        }
        static void PrintAcronym(string term)
        {
            string[] wordsFromTerm = term.Split(" ");
            string acronym = "";
            for (int i = 0; i < wordsFromTerm.Length; i++)
            {
                acronym += wordsFromTerm[i][0];
                Console.WriteLine("ASCII value of " + wordsFromTerm[i][0] + ": " + (int)wordsFromTerm[i][0]);
            }
            acronym = acronym.ToUpper();
            Console.WriteLine("Your acronym is: " + acronym);
        }
    }
}
