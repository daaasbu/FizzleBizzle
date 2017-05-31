using Xunit;

namespace FizzleBizzle.Tests
{
    public class FizzleBizzle_FizzBuzzShould
    {
        private readonly Project.Services.FizzleBizzle _fizzleBizzle;
        public FizzleBizzle_FizzBuzzShould()
        {
            _fizzleBizzle = new Project.Services.FizzleBizzle(3, 5);
        }
        [Theory]
        [InlineData(1,15)]
        [InlineData(2,12)]
        [InlineData(3,10)]
        public void ReturnLengthGivenValueOf(int start, int end)
        {
            var result = _fizzleBizzle.FizzBuzz(start, end);
            Assert.Equal(end - start + 1, result.Length);
        }
        [Fact]
        public void ReturnCorrectResultGivenValueOf1And15()
        {
            string[] correctResult = new string[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13" , "14", "FizzBuzz"};
            var result = _fizzleBizzle.FizzBuzz(1, 15);
            Assert.Equal(correctResult, result);     
        }
    }
}
