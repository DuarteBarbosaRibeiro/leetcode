public class Solution {
    /*
        If a subarray doesn't have 0s, to
        maximize the product, the subarray
        is split and the split point moved
        left to right. Maximum product is kept
        track of and returned.
    */
    int MaxProductWithoutZero(int[] nums, int start, int end) {
        // Edge case -> subarray length is 1
        if (end - start == 1)
            return nums[start];

        // product1 and product2 are the products
        // of the two halves of the subarray
        int result = int.MinValue, product1 = 1, product2 = 1;
        for (int i = start; i < end; i++)
            product2 *= nums[i];
        for (int i = start; i < end; i++) {
            product1 *= nums[i];
            product2 /= nums[i];
            if (product1 > result)
                result = product1;
            if (product2 > result)
                result = product2;
        }
        return result;
    }

    public int MaxProduct(int[] nums) {
        int result = int.MinValue, start = 0, end, temp;

        /*
            This for loop essencially just splits
            the array with 0. If a 0 is found it also
            updates result to be at least 1 because
            otherwise the result may be negative
            Example: [-1, -2]
            Answer: -1
        */
        for (end = 0; end < nums.Length; end++) {
            if (nums[start] == 0) {
                if (result < 0)
                    result = 0;
                start++;
                continue;
            }
            if (nums[end] == 0) {
                temp = MaxProductWithoutZero(nums, start, end);
                if (temp > result)
                    result = temp;
                start = end;
                if (result < 0)
                    result = 0;
            }
        }

        if (start < nums.Length && nums[start] != 0) {
            temp = MaxProductWithoutZero(nums, start, end);
            if (temp > result)
                result = temp;
        }
        
        return result;
    }
}