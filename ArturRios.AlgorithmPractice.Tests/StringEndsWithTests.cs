namespace ArturRios.AlgorithmPractice.Tests;

public class StringEndsWithTests
{
    [Theory]
    [InlineData("abc", "bc")]
    [InlineData("abc", "c")]
    [InlineData("abc", "")]
    [InlineData("samurai", "ai")]
    [InlineData("ninja", "ja")]
    [InlineData("sensei", "i")]
    [InlineData("abc", "abc")]
    [InlineData("abcabc", "bc")]
    [InlineData("fails", "ails")]
    [InlineData("!@#$%^&*() :-)", ":-)")]
    [InlineData("", "")]
    public void GivenAStringThatEndsWithTheEnding_WhenChecked_ThenItIsTrue(string str, string ending)
    {
        // When
        var endsWith = StringEndsWith.Solution(str, ending);

        // Then
        Assert.True(endsWith);
    }

    [Theory]
    [InlineData("abc", "d")]
    [InlineData("abc", "ab")]
    [InlineData("sumo", "omo")]
    [InlineData("samurai", "ra")]
    [InlineData("abc", "abcd")]
    [InlineData("ails", "fails")]
    [InlineData("this", "fails")]
    [InlineData(":-)", ":-(")]
    [InlineData("abc\n", "abc")]
    [InlineData("", "a")]
    [InlineData("abc", "abc ")]
    public void GivenAStringThatDoesNotEndWithTheEnding_WhenChecked_ThenItIsFalse(string str, string ending)
    {
        // When
        var endsWith = StringEndsWith.Solution(str, ending);

        // Then
        Assert.False(endsWith);
    }

    [Theory]
    [InlineData("abc", "C")]
    [InlineData("ABC", "bc")]
    public void GivenAnEndingInAnotherCase_WhenChecked_ThenItIsFalse(string str, string ending)
    {
        // When
        var endsWith = StringEndsWith.Solution(str, ending);

        // Then
        Assert.False(endsWith);
    }
}
