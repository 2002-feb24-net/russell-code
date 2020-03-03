using System;

namespace StringStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give me a string: ");
            string input = Console.ReadLine();

            //Solution 1
            Console.WriteLine("Reversed string (sol1): " + reverse(input));

            //Solution 2
            Console.WriteLine("Reversed string (sol2): " + reverse2(input));
        }
        static string reverse(string myStr)
        {
           string rev = "";
            for (int i = myStr.Length-1; i >= 0; i--)
            {
                rev += myStr[i];
            }
            return rev;
        }
        static string reverse2(string myStr)
        {
            char[] arr = myStr.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
