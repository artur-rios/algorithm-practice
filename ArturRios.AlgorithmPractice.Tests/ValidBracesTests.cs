namespace ArturRios.AlgorithmPractice.Tests;

public class ValidBracesTests
{
    [Theory]
    [InlineData("(){}[]")]
    [InlineData("([{}])")]
    [InlineData("()")]
    [InlineData("{}({})[]")]
    [InlineData("({})[({})]")]
    [InlineData("(({{[[]]}}))")]
    public void GivenBracesThatAllMatch_WhenChecked_ThenTheyAreValid(string braces)
    {
        // When
        var valid = ValidBraces.Solution(braces);

        // Then
        Assert.True(valid);
    }

    [Theory]
    [InlineData("(}")]
    [InlineData("[(])")]
    [InlineData("[({})](]")]
    [InlineData("([)]")]
    public void GivenABraceClosedByTheWrongKind_WhenChecked_ThenTheyAreInvalid(string braces)
    {
        // When
        var valid = ValidBraces.Solution(braces);

        // Then
        Assert.False(valid);
    }

    [Theory]
    [InlineData("(((({{")]
    [InlineData("())({}}{()][][")]
    [InlineData("[")]
    public void GivenBracesThatEndOpen_WhenChecked_ThenTheyAreInvalid(string braces)
    {
        // When
        var valid = ValidBraces.Solution(braces);

        // Then
        Assert.False(valid);
    }

    [Theory]
    [InlineData(")(")]
    [InlineData("}")]
    [InlineData("]()")]
    public void GivenBracesThatStartClosed_WhenChecked_ThenTheyAreInvalid(string braces)
    {
        // When
        var valid = ValidBraces.Solution(braces);

        // Then
        Assert.False(valid);
    }
}
