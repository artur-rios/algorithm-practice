namespace ArturRios.AlgorithmPractice.Tests;

public class BestTravelTests
{
    [Fact]
    public void GivenListOfDistances_WhenChoosingBestSum_ThenReturnsExactTarget()
    {
        var ts = new List<int> { 50, 55, 56, 57, 58 };
        
        var n = BestTravel.Solution(163, 3, ts);
        
        Assert.Equal(163, n);
    }

    [Fact]
    public void GivenInsufficientDistances_WhenChoosingBestSum_ThenReturnsNull()
    {
        var ts = new List<int> { 50 };
        
        var n = BestTravel.Solution(163, 3, ts);
        
        Assert.Null(n);
    }

    [Fact]
    public void GivenMultipleDistances_WhenChoosingBestSum_ThenReturnsClosestUnderTarget()
    {
        var ts = new List<int> { 91, 74, 73, 85, 73, 81, 87 };
        
        var n = BestTravel.Solution(230, 3, ts);
        
        Assert.Equal(228, n);
    }
}