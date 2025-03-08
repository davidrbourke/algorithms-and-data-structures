
// https://leetcode.com/problems/move-zeroes/

public class Solution {
    public void MoveZeroes(int[] nums) {
        var t = 0;
        for(var l = 0; l < nums.Length; l++ )
        {
            if(nums[l] != 0)
            {
                var mv = nums[t];
                nums[t++] = nums[l];
                nums[l] = mv;
            }
        }
    }
}