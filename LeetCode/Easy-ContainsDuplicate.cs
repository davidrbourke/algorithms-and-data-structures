// https://leetcode.com/problems/contains-duplicate/

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var hs = new HashSet<int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if (hs.Contains(nums[i]))
            {
                return true;
            }
            hs.Add(nums[i]);
        }

        return false;
    }
}