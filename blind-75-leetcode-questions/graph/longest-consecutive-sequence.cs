public class Solution {
    /*
        I genuinely have no idea how to
        solve this in O(n). This should
        algorithm should be O(n log n)
        as the longest block is the sort
        which takes O(n log n).
    */
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        Array.Sort(nums);
        int result = 1;
        int current = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1])
                continue;
            if (nums[i] == nums[i - 1] + 1) {
                current++;
                continue;
            }
            if (current > result)
                result = current;
            current = 1;
        }
        if (current > result)
            result = current;
        return result;
    }
}