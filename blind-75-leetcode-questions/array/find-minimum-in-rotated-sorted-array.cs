public class Solution {
    // All numbers in nums are unique so
    // min is less than the previous number
    bool IsMin(int[] nums, int index) {
        int prev_index = index - 1;
        if (prev_index < 0)
            prev_index = nums.Length - 1;
        return nums[index] < nums[prev_index];
    }

    /*
        Approach:

        If start is larger than end, then
        min must be in subarray. Split
        subarray and keep searching.

        If not, the first
        element may be min.
    */
    int FindMinRecursion(int[] nums, int start, int end) {
        if (nums[start] > nums[end]) {
            int middle = (start + end) / 2;
            int half1 = FindMinRecursion(nums, start, middle);
            int half2 = FindMinRecursion(nums, middle + 1, end);
            if (half1 < half2)
                return half1;
            return half2;
        }
        if (IsMin(nums, start))
            return nums[start];
        return int.MaxValue;
    }

    public int FindMin(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        return FindMinRecursion(nums, 0, nums.Length - 1);
    }
}