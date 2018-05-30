using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoreMvcTdd.Tests
{ 
    [Collection("Test")]
    public class UnitTests
    {
        [Fact]
        public void TestMethod1()
        {
            Assert.Equal(8, (4 * 2));
        }

        [Theory]
        [InlineData("name")]
        [InlineData("word")]
        public void TestMethod2(string value)
        {
            Assert.Equal(4, value.Length);
        }
    }

    [Collection("Test")]
    public class UnitTest2
    {
        [Fact] 
        public void TestMethod3()
        {
            Assert.Equal(2, 2 * 1);
        }
    }
}
