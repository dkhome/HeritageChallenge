using Xunit;

namespace Challenge
{
    public class Excercise2Tests
    {
        [Theory]
        [InlineData(false, null)]
        [InlineData(false, new char[] { 'w', 'e', 'w', 'e', })] //less than 10 minutes
        [InlineData(false, new char[] { 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e', 'w'})] //more than 10 minutes
        [InlineData(true, new char[] { 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e', 'w', 'e' })] //horizontal movements only
        [InlineData(true, new char[] { 'n', 's', 'n', 's', 'n', 's', 'n', 's', 'n', 's', })] //vertical movements only
        [InlineData(true, new char[] { 'n', 'n', 'n', 'n', 'n', 's', 's',  's',  's', 's', })] //vertical long movement and back
        [InlineData(true, new char[] { 'w', 'w', 'w', 'w', 'w', 'e', 'e', 'e', 'e', 'e', })] //horizontal long movement and back
        [InlineData(true, new char[] { 'n', 's', 'w', 'e', 'w', 'e', 'n', 's', 'n', 's', })] //going one step and back
        [InlineData(true, new char[] { 'n', 'w', 's', 'n', 'n', 'e', 'w', 'e', 's', 's', })] //going random directions
        public void TestSolution(bool expected, char[] input)
        {
            var excercise = new Excercise2();
            Assert.Equal(expected, excercise.Solution(input));
        }
    }
}
