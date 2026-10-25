namespace ArturRios.AlgorithmPractice.Tests;

public class MediumOfTwoSortedArraysTests
{
    [Fact]
    public void GivenTwoSortedArraysWithOddTotalLength_WhenSolutionCalled_ThenReturnMiddleElement()
    {
        int[] nums1 = [1, 3];
        int[] nums2 = [3];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(3.0, result);
    }

    [Fact]
    public void GivenTwoSortedArraysWithEvenTotalLength_WhenSolutionCalled_ThenReturnAverageOfTwoMiddleElements()
    {
        int[] nums1 = [1, 3];
        int[] nums2 = [2, 4];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(2.5, result);
    }

    [Fact]
    public void GivenEmptyFirstArrayAndNonEmptySecondArray_WhenSolutionCalled_ThenReturnMedianOfSecondArray()
    {
        int[] nums1 = [];
        int[] nums2 = [1];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(1.0, result);
    }

    [Fact]
    public void GivenNonEmptyFirstArrayAndEmptySecondArray_WhenSolutionCalled_ThenReturnMedianOfFirstArray()
    {
        int[] nums1 = [2];
        int[] nums2 = [];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(2.0, result);
    }

    [Fact]
    public void GivenTwoLargeEvenLengthArrays_WhenSolutionCalled_ThenReturnCorrectMedian()
    {
        int[] nums1 = [1, 2];
        int[] nums2 = [3, 4];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(2.5, result);
    }

    [Fact]
    public void GivenArraysWithNegativeNumbers_WhenSolutionCalled_ThenReturnCorrectMedian()
    {
        int[] nums1 = [-4, -1];
        int[] nums2 = [-3, -2];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(-2.5, result);
    }

    [Fact]
    public void GivenArraysWithDuplicates_WhenSolutionCalled_ThenReturnCorrectMedian()
    {
        int[] nums1 = [1, 1];
        int[] nums2 = [1, 1];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(1.0, result);
    }

    [Fact]
    public void GivenUnsortedCombinedArrays_WhenSolutionCalled_ThenReturnCorrectMedian()
    {
        int[] nums1 = [3, 1];
        int[] nums2 = [4, 2];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(2.5, result);
    }

    [Fact]
    public void GivenArraysWithMixedPositiveAndNegative_WhenSolutionCalled_ThenReturnCorrectMedian()
    {
        int[] nums1 = [-2, 0];
        int[] nums2 = [1, 3];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(0.5, result);
    }

    [Fact]
    public void GivenSingleElementInEachArray_WhenSolutionCalled_ThenReturnAverageOfBothElements()
    {
        int[] nums1 = [5];
        int[] nums2 = [7];
        
        var result = MediumOfTwoSortedArrays.Solution(nums1, nums2);
        
        Assert.Equal(6.0, result);
    }
}