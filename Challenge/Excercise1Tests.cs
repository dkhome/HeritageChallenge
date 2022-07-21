using Xunit;

namespace Challenge
{
    public class Excercise1Tests
    {
        [Theory]
        [InlineData(0, new string[] { "a", "b", "c" })]
        [InlineData(1, new string[] { "a", "b", "cc" })]
        [InlineData(2, new string[] { "ABC", "deef", "hi", "mnmn" })]
        [InlineData(2, new string[] { "AABBCCDDDDD", "123", "xyz", "qwertt" })]
        [InlineData(3, new string[] { "123a", "1233", "11", "tttttxxxxxzzzzz" })]
        [InlineData(0, new string[] { })]
        [InlineData(0, null)]
        public void TestSolution(int expected, string[] input)
        {
            var excercise = new Excercise1();
            Assert.Equal(expected, excercise.Solution(input));
        }
    }
}
