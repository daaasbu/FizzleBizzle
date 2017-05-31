using System;
using Xunit;
using FizzleBizzle.Project.Factories;

namespace FizzleBizzle.Test
{
    class PredicateFactory_ConstructPredicateShould
    {
            
        [Theory]
        [InlineData("<", 10, 9)]
        [InlineData("<=", 10, 9)]
        [InlineData("==", 10, 10)]
        [InlineData(">", 10, 11)]
        [InlineData(">=", 10, 11)]
        [InlineData("==", 10, 10)]
        [InlineData("!=", 10, 11)]
        public void shouldReturnTrueGivenValueOf(string op, int n, int a)
        {
            var opPredicate = new PredicateFactory(op, a);
            Assert.True(opPredicate.ConstructPredicate()(n));
        }

        [Theory]
        [InlineData("<", 9, 10)]
        [InlineData("<=", 9, 10)]
        [InlineData("==", 11, 10)]
        [InlineData(">", 11, 10)]
        [InlineData(">=", 11, 10)]
        [InlineData("==", 9, 10)]
        [InlineData("!=", 11, 11)]
        public void shouldReturnFalseGivenValueOf(string op, int n, int a)
        {
            var opPredicate = new PredicateFactory(op, a);
            Assert.True(opPredicate.ConstructPredicate()(n));
        }
    }
}
