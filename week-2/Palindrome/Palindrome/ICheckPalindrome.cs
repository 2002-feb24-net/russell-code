using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeLibrary
{
    interface ICheckPalindrome
    {
        bool IsPalindrome(string str);
        string CleanString(string str);
    }
}
