using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Utils;
using Xunit;
namespace AlgorithmsTest
{
    public class SqrtxTest
    {
        [Theory]
        [InlineData(0,1)]
        public void TestMethod(int x, int output)
        {
            Assert.Equal(output, Solution069.MySqrt(x));
        }
    }
}

