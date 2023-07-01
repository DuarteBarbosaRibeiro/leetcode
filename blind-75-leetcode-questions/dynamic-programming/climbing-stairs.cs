public class Solution {
    static int Choose(int n, int p) {
        long result = 1;

        for (int i = 1; i <= n - p; i++) {
            result *= n - i + 1;
            result /= i;
        }

        return (int) result;
    }

    public int ClimbStairs(int n) {
        int max_double_steps = n / 2;
        int result = 0;

        for (int i = 0; i <= max_double_steps; i++)
            result += Choose(n - i, i);
        
        return result;
    }
}