public class Solution {
    void ChooseBestPath(int[,] dp, int y, int x, int value) {
        // If at bottom right corner then done
        if (y == dp.GetLength(0) - 1 && x == dp.GetLength(1) - 1) {
            dp[y, x] = value;
            return;
        }
        // If at bottom go right
        if (y == dp.GetLength(0) - 1) {
            dp[y, x] = value + dp[y, x + 1];
            return;
        }
        // If at right go down
        if (x == dp.GetLength(1) - 1) {
            dp[y, x] = value + dp[y + 1, x];
            return;
        }

        // Pick smallest between right and down
        if (dp[y, x + 1] < dp[y + 1, x]) {
            dp[y, x] = value + dp[y, x + 1];
            return;
        }
        dp[y, x] = value + dp[y + 1, x];
    }

    public int MinPathSum(int[][] grid) {
        int[,] dp = new int[grid.Length, grid[0].Length];
        for (int y = 0; y < dp.GetLength(0); y++)
            for (int x = 0; x < dp.GetLength(1); x++)
                dp[y, x] = int.MaxValue;

        // For ChooseBestPath to work, the grid needs to be
        // navigated in the right order or else uninitialized
        // memory will be accessed.
        for (int y = dp.GetLength(0) - 1; y >= 0; y--)
            for (int x = dp.GetLength(1) - 1; x >= 0; x--)
                ChooseBestPath(dp, y, x, grid[y][x]);
        return dp[0, 0];
    }
}