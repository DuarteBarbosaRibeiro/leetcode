public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> table = new();

        for (int index = 0; index < nums.Length; index++) {
            if (table.ContainsKey(target - nums[index]))
                return new int[] { table[target - nums[index]], index };
            table.TryAdd(nums[index], index);
        }

        return new int[] {};
    }
}