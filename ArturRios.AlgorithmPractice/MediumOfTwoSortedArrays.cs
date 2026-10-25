namespace ArturRios.AlgorithmPractice;

public static class MediumOfTwoSortedArrays
{
    /*
     * https://leetcode.com/problems/median-of-two-sorted-arrays/
     */
    public static double Solution(int[] nums1, int[] nums2)
    {
        var mergedArrays = nums1.Concat(nums2).ToArray();
        mergedArrays.Sort();
        
        var length = mergedArrays.Length;

        if (length == 1)
        {
            return mergedArrays[0];
        }
        
        var middle = (int)Math.Floor((double)mergedArrays.Length / 2);
        
        if (length % 2 == 0)
        {
            return (mergedArrays[middle - 1] + mergedArrays[middle]) / 2.0;
        }
        
        return mergedArrays[middle];
    }
}