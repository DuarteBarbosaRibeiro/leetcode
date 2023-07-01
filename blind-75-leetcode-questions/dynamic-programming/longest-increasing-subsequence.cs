public class Solution {
    /*
        Pretty proud of this solution, learning
        about dynamic programming. dp keeps track
        of the longest subsequence possible that
        ends at the respective index in nums. So
        the next element in dp is 1 more than the
        max before where nums is less than the current.
    */
    public int LengthOfLIS(int[] nums) {
        int[] dp = new int[nums.Length];
        int result = 1;
        for (int i = 0; i < nums.Length; i++) {
            int max = 0;
            for (int j = 0; j < i; j++)
                if (nums[j] < nums[i] && dp[j] > max)
                    max = dp[j];
            max++;
            dp[i] = max;
            if (max > result)
                result = max;
        }
        return result;
    }
}