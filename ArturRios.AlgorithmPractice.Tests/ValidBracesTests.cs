namespace ArturRios.AlgorithmPractice.Tests;

public class ValidBracesTests
{
    [Theory]
    [InlineData("(){}[]")]
    [InlineData("([{}])")]
    public void Given_ValidBraces_When_CallingMethod_Then_ReturnTrue(string braces)
    {
        Assert.True(ValidBraces.Solution(braces));
    }

    [Theory]
    [InlineData("(}")]
    [InlineData("[(])")]
    [InlineData("[({})](]")]
    public void Given_InvalidBraces_When_CallingMethod_Then_ReturnFalse(string braces)
    {
        Assert.False(ValidBraces.Solution(braces));
    }
}
