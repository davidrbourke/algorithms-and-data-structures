public class Solution {
    public void Rotate(int[] nums, int k) {
        if (nums.Length == 1 || k == 0 || k == nums.Length)
            return;
        
        k %= nums.Length;

        int pos = 0;
        int nextValueWrite = nums[pos];
        int srcIndex = pos+k;
        for(var i = 0; i < nums.Length; i++)
        {
            var nextValueRead = nums[srcIndex];
            nums[srcIndex] = nextValueWrite;
            nextValueWrite = nextValueRead;

            if (srcIndex == pos) {
                srcIndex++;
                pos++;
                nextValueWrite = nums[pos];
            }

            srcIndex = (srcIndex +k) % nums.Length;
        }

    }
}