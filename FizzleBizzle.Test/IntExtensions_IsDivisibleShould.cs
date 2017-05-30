using System;
using Xunit;
using FizzleBizzle.Extensions;

namespace FizzleBizzle.Tests
{
    public class IntExtensions_IsDivisibleShould
    {
        [Theory]
        [InlineData(3, 3)]
        [InlineData(6, 3)]
        [InlineData(5, 5)]
        [InlineData(10, 5)]
        public void ShouldReturnTrue(int a, int n)
        {
            Assert.True(a.IsDivisible(n));
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(5, 3)]
        [InlineData(4, 5)]
        [InlineData(7, 5)]
        public void ShouldReturnFalse(int a, int n)
        {
            Assert.False(a.IsDivisible(n));
        }
    }
}
