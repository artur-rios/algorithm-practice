namespace ArturRios.AlgorithmPractice.Tests;

public class BestTravelTests
{
    private static readonly int[] Kata = [91, 74, 73, 85, 73, 81, 87];

    private static readonly int[] Long = [100, 76, 56, 44, 89, 73, 68, 56, 64, 123, 2333, 144, 50, 132, 123, 34, 89];

    public static TheoryData<int, int, int[], int> KnownAnswers => new()
    {
        { 174, 3, [50, 55, 57, 58, 60], 173 },
        { 163, 3, [50, 55, 56, 57, 58], 163 },
        { 230, 3, Kata, 228 },
        { 331, 2, Kata, 178 },
        { 331, 4, Kata, 331 },
        { 331, 1, Kata, 91 },
        { 700, 6, Kata, 491 },
        { 230, 4, Long, 230 },
        { 430, 5, Long, 430 },
        { 880, 8, Long, 876 },
        { 2430, 15, Long, 1287 },
        { 100, 2, [100, 64, 123, 2333, 144, 50, 132, 123, 34, 89], 98 }
    };

    public static TheoryData<int, int, int[]> NoSumFits => new()
    {
        { 331, 5, Kata },
        { 430, 8, Long },
        { 49, 1, [50] },
        { 0, 1, [1, 2] }
    };

    [Theory]
    [MemberData(nameof(KnownAnswers))]
    public void GivenTheKatasExamples_WhenChoosingTheBestSum_ThenItIsTheLargestSumOfKDistancesNotOverT(
        int t, int k, int[] distances, int expected)
    {
        // When
        var best = BestTravel.Solution(t, k, [.. distances]);

        // Then
        Assert.Equal(expected, best);
    }

    [Theory]
    [MemberData(nameof(NoSumFits))]
    public void GivenEverySumOfKDistancesIsOverT_WhenChoosingTheBestSum_ThenThereIsNone(int t, int k, int[] distances)
    {
        // When
        var best = BestTravel.Solution(t, k, [.. distances]);

        // Then
        Assert.Null(best);
    }

    [Fact]
    public void GivenFewerDistancesThanK_WhenChoosingTheBestSum_ThenThereIsNone()
    {
        // When
        var best = BestTravel.Solution(163, 3, [50]);

        // Then
        Assert.Null(best);
    }

    [Fact]
    public void GivenAsManyDistancesAsK_WhenChoosingTheBestSum_ThenItIsTheirTotal()
    {
        // When
        var best = BestTravel.Solution(300, 3, [50, 60, 70]);

        // Then
        Assert.Equal(180, best);
    }

    [Fact]
    public void GivenASumExactlyAtT_WhenChoosingTheBestSum_ThenItIsChosen()
    {
        // When
        var best = BestTravel.Solution(50, 1, [50]);

        // Then
        Assert.Equal(50, best);
    }

    [Fact]
    public void GivenTheSameDistanceTwice_WhenChoosingTheBestSum_ThenBothCanBeTaken()
    {
        // When
        var best = BestTravel.Solution(10, 2, [5, 5]);

        // Then
        Assert.Equal(10, best);
    }

    [Fact]
    public void GivenAListOfDistances_WhenChoosingTheBestSum_ThenTheListIsLeftAsItWas()
    {
        // Given
        var distances = new List<int>(Kata);

        // When
        BestTravel.Solution(230, 3, distances);

        // Then
        Assert.Equal(Kata, distances);
    }
}
