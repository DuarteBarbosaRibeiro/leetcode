public class Solution {
    // Change max_count so that the function removes duplicates
    // So that there's at most max_count of each number
    const int max_count = 2;

    public int RemoveDuplicates(int[] nums) {
        // Index to traverse the array
        int i = 0;
        // Index where future numbers should be written to
        int j = 0;
        int count;
        int current;

        while (i < nums.Length) {
            current = nums[i];
            count = 0;

            // Count up to max_count of current
            while (count < max_count && i < nums.Length && nums[i] == current) {
                i++;
                count++;
            }

            // Write current count times starting at index j
            for (int k = 0; k < count; k++) {
                nums[j] = current;
                j++;
            }

            // Find the next current
            while (i < nums.Length && nums[i] == current)
                i++;
        }
        return j;
    }
}