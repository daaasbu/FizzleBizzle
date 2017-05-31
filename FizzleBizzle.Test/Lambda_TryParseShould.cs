using System;
using Xunit;
using FizzleBizzle.Project.Extensions;
namespace FizzleBizzle.Test
{
    public class Lambda_TryParseShould
    {
        [Theory]
        [InlineData(">=")]
        [InlineData(">")]
        [InlineData("<=")]
        [InlineData("<")]
        [InlineData("==")]
        [InlineData("==")]

        public void ReturnTrue(string op)
        { 
            Func<int, Func<int, bool>> result;
            Assert.True(Lambda.TryParse(op, out result));
        }

        [Theory]
        [InlineData("")]
        [InlineData("agsr")]
        [InlineData("?")]
        [InlineData("=>")]
        public void ReturnFalse(string op)
        {
            Func<int, Func<int, bool>> result;
            Assert.False(Lambda.TryParse(op, out result));
        }


    }
}
