using PalindromeLibrary;
using System;
using Xunit;

namespace XUnitTestPalindrome
{
    public class UnitTest1
    {
        PalindromeSolver solver = new PalindromeSolver();

        // This method tests that the clean string method works as intented.
        [Fact]
        public void TestCleanString()
        {
            Assert.Equal("", solver.CleanString(""));
            Assert.Equal("helloworld", solver.CleanString("Hello World!"));
            Assert.Equal("31410314", solver.CleanString("3.14 * 10 = 31.4"));
            Assert.NotEqual("Oh, hi Mark.", solver.CleanString("Oh, hi Mark."));
        }

        // This method tests some strings that are in fact palindromes.
        [Fact]
        public void TestPalindrome1()
        {
            Assert.True(solver.IsPalindrome("A nut for a jar of tuna."));
            Assert.True(solver.IsPalindrome("Al lets Della call Ed \"Stella.\""));
            Assert.True(solver.IsPalindrome("1 + 1 = 2, 2 = 1 + 1"));
            Assert.True(solver.IsPalindrome("never odd, or even."));
        }
        // This method tests some strings that are not palindromes.
        [Fact]
        public void TestPalindrome2()
        {
            Assert.False(solver.IsPalindrome("one two one"));
            Assert.False(solver.IsPalindrome("123abccba123"));
        }
    }
}
