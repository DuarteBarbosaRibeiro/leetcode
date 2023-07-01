public class Solution {
    public int GetSum(int a, int b) {
        int sum, remainder;
        do {
            sum = a ^ b;
            remainder = (a & b) << 1;
            a = sum;
            b = remainder;
        } while (remainder != 0);
        return sum;
    }
}