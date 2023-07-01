public class Solution {
    public int MissingNumber(int[] nums) {
        bool[] contains = new bool[nums.Length + 1];
        for (int i = 0; i < contains.Length; i++)
            contains[i] = false;
        for (int i = 0; i < nums.Length; i++)
            contains[nums[i]] = true;
        for (int i = 0; i < contains.Length; i++)
            if (!contains[i])
                return i;
        // Should not reach here
        return 0;
    }
}