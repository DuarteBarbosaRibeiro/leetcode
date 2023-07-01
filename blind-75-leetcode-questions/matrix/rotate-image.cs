public class Solution {
    public void Rotate(int[][] matrix) {
        int n = matrix.Length;

        //Rotate 4 quadrants excluding middle row and column
        for (int y = 0; y < n / 2; y++) {
            for (int x = 0; x < n / 2; x++) {
                int temp = matrix[y][x];
                matrix[y][x] = matrix[n - x - 1][y];
                matrix[n - x - 1][y] = matrix[n - y - 1][n - x - 1];
                matrix[n - y - 1][n - x - 1] = matrix[x][n - y - 1];
                matrix[x][n - y - 1] = temp;
            }
        }

        // Rotate middle row and column
        if (n % 2 == 1) {
            for (int i = 0; i < n / 2; i++) {
                int temp = matrix[i][n / 2];
                matrix[i][n / 2] = matrix[n / 2][i];
                matrix[n / 2][i] = matrix[n - i - 1][n / 2];
                matrix[n - i - 1][n / 2] = matrix[n / 2][n - i - 1];
                matrix[n / 2][n - i - 1] = temp;
            }
        }
    }
}