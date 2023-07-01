public class Solution {
    public int MaxSubArray(int[] nums) {
        int result = int.MinValue;
        int sum = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            sum += nums[i];
            if (sum > result)
                result = sum;
            if (sum < 0)
                sum = 0;
        }
        
        return result;
    }
}