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
    public void Given_StringThatEndsWithEnding_When_CallingMethod_Then_ReturnTrue(string str, string ending)
    {
        Assert.True(StringEndsWith.Solution(str, ending));
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
    public void Given_StringThatDoesNotEndWithEnding_When_CallingMethod_Then_ReturnFalse(string str, string ending)
    {
        Assert.False(StringEndsWith.Solution(str, ending));
    }
}