namespace ArturRios.AlgorithmPractice.Tests;

public class MediumOfTwoSortedArraysTests
{
    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2 }, 2.0)]
    [InlineData(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
    public void GivenTheProblemsExamples_WhenFindingTheMedian_ThenItIsTheKnownAnswer(int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 3 }, 3.0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 6, 7 }, 4.0)]
    [InlineData(new[] { 1 }, new[] { 2, 3, 4, 5, 6, 7, 8, 9 }, 5.0)]
    public void GivenAnOddTotalLength_WhenFindingTheMedian_ThenItIsTheMiddleElement(int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new[] { 1, 3 }, new[] { 2, 4 }, 2.5)]
    [InlineData(new[] { 5 }, new[] { 7 }, 6.0)]
    [InlineData(new[] { 1, 2, 3, 4, 5 }, new[] { 6 }, 3.5)]
    [InlineData(new[] { 1 }, new[] { 2, 3, 4, 5, 6, 7, 8 }, 4.5)]
    public void GivenAnEvenTotalLength_WhenFindingTheMedian_ThenItIsTheMeanOfTheTwoMiddleElements(
        int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new int[0], new[] { 1 }, 1.0)]
    [InlineData(new[] { 2 }, new int[0], 2.0)]
    [InlineData(new int[0], new[] { 2, 3 }, 2.5)]
    [InlineData(new[] { 1, 2, 3 }, new int[0], 2.0)]
    public void GivenOneEmptyArray_WhenFindingTheMedian_ThenItIsTheMedianOfTheOther(int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new[] { -4, -1 }, new[] { -3, -2 }, -2.5)]
    [InlineData(new[] { -2, 0 }, new[] { 1, 3 }, 0.5)]
    [InlineData(new[] { 1, 1 }, new[] { 1, 1 }, 1.0)]
    [InlineData(new[] { 3, 1 }, new[] { 4, 2 }, 2.5)]
    public void GivenNegativesDuplicatesOrUnsortedInput_WhenFindingTheMedian_ThenItIsStillTheMedian(
        int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new[] { 1000000 }, new[] { 1000000 }, 1000000.0)]
    [InlineData(new[] { -1000000 }, new[] { 1000000 }, 0.0)]
    [InlineData(new[] { -1000000, -999999 }, new[] { -1000000 }, -1000000.0)]
    public void GivenValuesAtTheProblemsBounds_WhenFindingTheMedian_ThenItIsExact(int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Theory]
    [InlineData(new[] { int.MaxValue }, new[] { int.MaxValue }, 2147483647.0)]
    [InlineData(new[] { int.MinValue }, new[] { int.MinValue }, -2147483648.0)]
    [InlineData(new[] { int.MaxValue - 1 }, new[] { int.MaxValue }, 2147483646.5)]
    public void GivenMiddleElementsWhoseSumOverflowsAnInt_WhenFindingTheMedian_ThenItIsStillTheirMean(
        int[] nums1, int[] nums2, double expected)
    {
        // When
        var median = MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal(expected, median);
    }

    [Fact]
    public void GivenTwoArrays_WhenFindingTheMedian_ThenNeitherIsChanged()
    {
        // Given
        int[] nums1 = [3, 1];
        int[] nums2 = [4, 2];

        // When
        MediumOfTwoSortedArrays.Solution(nums1, nums2);

        // Then
        Assert.Equal([3, 1], nums1);
        Assert.Equal([4, 2], nums2);
    }
}
