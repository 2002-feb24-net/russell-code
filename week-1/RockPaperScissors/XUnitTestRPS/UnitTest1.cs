using RockPaperScissors.Library;
using System;
using Xunit;

namespace XUnitTestRPS
{
    public class UnitTest1
    {
        // c# has something called "attributes"
        // things you can put in brackets on top of stuff like methods
        // 
        [Fact] // marks this method for xUnit as a test method
        public void TrueShouldBeTrue()
        {
            Assert.True(true);
        }

        // (doesn't say "Fact" so this isn't a test method)
        public static void HelperMethod()
        {

        }
        [Fact]
        public void TestSmartStrategy()
        {
            var strategy = new RpsSmartStrategy();
            Assert.Equal("R", strategy.DecideMove("S"));
            Assert.True("P" == strategy.DecideMove("R"));
            Assert.False("S" == strategy.DecideMove("S"));
            Assert.NotEqual("Hello", strategy.DecideMove(""));
        }
    }
}
