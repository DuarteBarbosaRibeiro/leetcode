public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] result = new int[nums.Length];
        int product = 1;

        // Check for 0
        int zero_index = -1;
        for (int index = 0; index < nums.Length; index++) {
            if (nums[index] == 0) {
                zero_index = index;
                break;
            }
        }

        /*
            If there is a 0, every element in
            result is 0 except for the element
            corresponding to the 0 in nums.

            If there's 2 0s product will be 0
            and the array will be all 0s.
        */
        if (zero_index >= 0) {
            for (int index = 0; index < nums.Length; index++) {
                if (index == zero_index)
                    continue;
                result[index] = 0;
                product *= nums[index];
            }
            result[zero_index] = product;
            return result;
        }

        foreach (int num in nums)
            product *= num;
        for (int index = 0; index < nums.Length; index++)
            result[index] = product / nums[index];
        return result;
    }
}