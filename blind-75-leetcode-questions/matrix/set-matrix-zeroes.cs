public class Solution {
    public void SetZeroes(int[][] matrix) {
        // I could just save the state of the matrix
        // in a seperate bool[][], but this also works
        const int PLACEHOLDER = int.MinValue + 2391;

        for (int y = 0; y < matrix.Length; y++) {
            for (int x = 0; x < matrix[y].Length; x++) {
                if (matrix[y][x] == 0) {
                    for (int Y = 0; Y < matrix.Length; Y++)
                        if (matrix[Y][x] != 0)
                            matrix[Y][x] = PLACEHOLDER;
                    for (int X = 0; X < matrix[y].Length; X++)
                        if (matrix[y][X] != 0)
                            matrix[y][X] = PLACEHOLDER;
                }
            }
        }
        for (int y = 0; y < matrix.Length; y++)
            for (int x = 0; x < matrix[y].Length; x++)
                if (matrix[y][x] == PLACEHOLDER)
                    matrix[y][x] = 0;
    }
}