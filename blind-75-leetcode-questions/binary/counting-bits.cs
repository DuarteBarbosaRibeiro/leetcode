public class Solution {
    /*
        Approach:
        Numbers like 1xxx have 1 more
        bit than corresponding numbers
        like 0xxx. So double up the
        array, append and add one.
    */
    public int[] CountBits(int n) {
        int[] result = new int[n + 1];

        // Setup initial cases
        if (n >= 0)
            result[0] = 0;
        if (n >= 1)
            result[1] = 1;
        int length = 2;
        while (length <= n) {
            for (int i = 0; i < length; i++) {
                if (i + length > n)
                    break;
                result[i + length] = result[i] + 1;
            }
            length *= 2;
        }
        return result;
    }
}