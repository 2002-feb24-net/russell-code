using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PalindromeLibrary
{
    public class PalindromeSolver : ICheckPalindrome
    {
        // This method efficiently checks if a string is a palindrome by iterating only n/2 times.
        public bool IsPalindrome(string checkString)
        {
            string lowerAlphaNums = CleanString(checkString);
            int len = lowerAlphaNums.Length - 1;
            for (int i = 0; i <= len / 2; i++)
            {
                if (lowerAlphaNums[i] != lowerAlphaNums[len - i])
                {
                    return false;
                }
            }
            return true;
        }
        // The clean string method is used to create a string consisting only of the following:
        //   1. Lowercase Alphabetical Characters
        //   2. Numerical Characters
        public string CleanString(string dirtyString)
        {
            string lowercase = dirtyString.ToLower();
            // Regex is used to create strings using Regular Expressions
            // [^a-z0-9] basically means any character that's not a lowercase alphabetical or numerical character.
            string lowerAlphabetsAndNumerics = Regex.Replace(lowercase, "[^a-z0-9]", String.Empty);
            return lowerAlphabetsAndNumerics;
        }
    }
}
