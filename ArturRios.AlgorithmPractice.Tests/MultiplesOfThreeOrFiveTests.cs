namespace ArturRios.AlgorithmPractice.Tests;

public class MultiplesOfThreeOrFiveTests
{
    [Theory]
    [InlineData(10, 23)]
    [InlineData(20, 78)]
    [InlineData(1000, 233168)]
    [InlineData(-1,0)]
    public void Solution_Should_Return_Correct_Sum(int value, int expected)
    {
        var result = MultiplesOfThreeOrFive.Solution(value);
        
        Assert.Equal(expected, result);
    }
}