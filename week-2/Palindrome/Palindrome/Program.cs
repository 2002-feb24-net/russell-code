using System;

namespace PalindromeLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var solver = new PalindromeSolver();
            string hello = "Hello World!";
            Console.WriteLine($"Is '{hello}' a palindrome?");
            bool results = solver.IsPalindrome(hello);
            if (results)
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No...");
            }
        }
    }
}
