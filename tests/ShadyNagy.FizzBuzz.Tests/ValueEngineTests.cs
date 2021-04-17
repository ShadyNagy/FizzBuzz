using Shouldly;
using Xunit;

namespace ShadyNagy.FizzBuzz.Tests
{
    public class ValueEngineTests
    {
        private readonly ValueEngine _valueEngine;

        public ValueEngineTests()
        {
            _valueEngine = new ValueEngine();
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        [InlineData(8)]
        [InlineData(11)]
        [InlineData(13)]
        [InlineData(14)]
        [InlineData(16)]
        public void ReturnsSameValueGivenNotDivideBy3AndNotDivideBy5(int input)
        {
            var result = _valueEngine.Create(input);

            result.ShouldBe(input.ToString());
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void ReturnsFizzGivenDivideBy3(int input)
        {
            var result = _valueEngine.Create(input);
            const string expected = "Fizz";

            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void ReturnsBuzzGivenDivideBy5(int input)
        {
            var result = _valueEngine.Create(input);
            const string expected = "Buzz";

            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void ReturnsFizzBuzzGivenDivideBy3AndDivideBy5(int input)
        {
            var result = _valueEngine.Create(input);
            const string expected = "FizzBuzz";

            result.ShouldBe(expected);
        }
    }
}
