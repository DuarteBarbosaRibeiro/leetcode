public class Solution {
    void Rotate(ref int dx, ref int dy) {
        int temp = dx;
        dx = -dy;
        dy = temp;
    }

    public IList<int> SpiralOrder(int[][] matrix) {
        bool[][] visited = new bool[matrix.Length][];

        for (int i = 0; i < visited.Length; i++) {
            visited[i] = new bool[matrix[0].Length];
            for (int j = 0; j < visited[0].Length; j++)
                visited[i][j] = false;
        }

        IList<int> result = new List<int>();
        int y = 0, x = 0, dy = 0, dx = 1;
        int count = matrix.Length * matrix[0].Length;
        while (result.Count < count) {
            result.Add(matrix[y][x]);
            visited[y][x] = true;

            // Check for out of bounds and rotate
            if (
                y + dy < 0 || y + dy >= matrix.Length ||
                x + dx < 0 || x + dx >= matrix[0].Length ||
                visited[y + dy][x + dx]
            )
                Rotate(ref dx, ref dy);

            y += dy;
            x += dx;
        }

        return result;
    }
}