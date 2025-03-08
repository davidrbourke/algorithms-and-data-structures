// https://leetcode.com/problems/maximum-subarray/

// https://en.wikipedia.org/wiki/Maximum_subarray_problem
public class Solution {
    public int MaxSubArray(int[] nums) {
        var bestSum = Int32.MinValue;
        var currentSum = 0;
        foreach(var i in nums)
        {
            currentSum = Math.Max(i, currentSum + i);
            bestSum = Math.Max(bestSum, currentSum);
        }
        return bestSum;
    }
}
