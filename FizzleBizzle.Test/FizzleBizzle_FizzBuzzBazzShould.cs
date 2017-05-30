using System;
using Xunit;
using FizzleBizzle.Services;

namespace FizzleBizzle.Tests
{
    public class FizzleBizzle_FizzBuzzBazzShould
    {
        private readonly Services.FizzleBizzle _fizzleBizzle;
        public FizzleBizzle_FizzBuzzBazzShould()
        {
            _fizzleBizzle = new Services.FizzleBizzle(2, 3);
        }

        [Theory]
        [InlineData(1, 15)]
        [InlineData(2, 12)]
        [InlineData(3, 10)]
        public void ReturnLengthGivenValueOf(int start, int end)
        {
            var result = _fizzleBizzle.FizzBuzzBazz(start, end, x => x > 6);
            Assert.Equal(end - start + 1, result.Length);
        }

        [Fact]
        public void ReturnCorrectResultGivenValueOf1And15()
        {
            string[] correctResult = new string[] { "1", "Fizz", "Buzz", "Fizz", "5", "FizzBuzz", "7", "Fizz", "Buzz", "Fizz", "11", "FizzBuzzBazz", "13", "Fizz", "Buzz" };
            var result = _fizzleBizzle.FizzBuzzBazz(1, 15, x => x > 6);
            Assert.Equal(correctResult, result);
        }

        [Fact]
        public void ReturnCorrectResultGivenValueOf6And15AndXGreaterThan6()
        {
            string[] correctResult = new string[] {"FizzBuzzBazz", "13", "Fizz", "Buzz" };
            var result = _fizzleBizzle.FizzBuzzBazz(12, 15, x => x > 6);
            Assert.Equal(correctResult, result);
        }
    }
}
