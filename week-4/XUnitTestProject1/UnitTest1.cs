using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // True is true.
            Assert.True(true);
        }
        [Fact]
        public void Test2()
        {
            // False is false.
            Assert.False(false);
        }
    }
}
