namespace ArturRios.AlgorithmPractice.Tests;

public class MultiplesOfThreeOrFiveTests
{
    [Theory]
    [InlineData(10, 23)]
    [InlineData(20, 78)]
    [InlineData(200, 9168)]
    [InlineData(1000, 233168)]
    public void GivenTheKatasExamples_WhenSummingTheMultiplesBelowIt_ThenTheSumIsTheKnownAnswer(int value, int expected)
    {
        // When
        var sum = MultiplesOfThreeOrFive.Solution(value);

        // Then
        Assert.Equal(expected, sum);
    }

    [Theory]
    [InlineData(3, 0)]
    [InlineData(4, 3)]
    [InlineData(5, 3)]
    [InlineData(6, 8)]
    public void GivenAMultipleItself_WhenSumming_ThenOnlyTheNumbersBelowItCount(int value, int expected)
    {
        // When
        var sum = MultiplesOfThreeOrFive.Solution(value);

        // Then
        Assert.Equal(expected, sum);
    }

    [Theory]
    [InlineData(15, 45)]
    [InlineData(16, 60)]
    public void GivenAMultipleOfBothThreeAndFive_WhenSumming_ThenItIsCountedOnce(int value, int expected)
    {
        // When
        var sum = MultiplesOfThreeOrFive.Solution(value);

        // Then
        Assert.Equal(expected, sum);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(0)]
    [InlineData(-1)]
    [InlineData(-5)]
    public void GivenANumberWithNoPositiveMultipleBelowIt_WhenSumming_ThenTheSumIsZero(int value)
    {
        // When
        var sum = MultiplesOfThreeOrFive.Solution(value);

        // Then
        Assert.Equal(0, sum);
    }
}
