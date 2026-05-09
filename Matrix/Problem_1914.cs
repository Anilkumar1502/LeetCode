public class Solution {
    public int[][] RotateGrid(int[][] grid, int k) {
         int m = grid.Length;
        int n = grid[0].Length;

        int layers = Math.Min(m, n) / 2;

        for(int layer = 0; layer < layers; layer++) {

            List<int> vals = new List<int>();

            int top = layer;
            int left = layer;

            int bottom = m - layer - 1;
            int right = n - layer - 1;

            // top row
            for(int j = left; j <= right; j++) {
                vals.Add(grid[top][j]);
            }

            // right column
            for(int i = top + 1; i <= bottom - 1; i++) {
                vals.Add(grid[i][right]);
            }

            // bottom row
            for(int j = right; j >= left; j--) {
                vals.Add(grid[bottom][j]);
            }

            // left column
            for(int i = bottom - 1; i >= top + 1; i--) {
                vals.Add(grid[i][left]);
            }

            int sz = vals.Count;

            int idx = k % sz;

            // top row
            for(int j = left; j <= right; j++) {

                grid[top][j] = vals[idx];

                idx++;

                if(idx == sz) {
                    idx = 0;
                }
            }

            // right column
            for(int i = top + 1; i <= bottom - 1; i++) {

                grid[i][right] = vals[idx];

                idx++;

                if(idx == sz) {
                    idx = 0;
                }
            }

            // bottom row
            for(int j = right; j >= left; j--) {

                grid[bottom][j] = vals[idx];

                idx++;

                if(idx == sz) {
                    idx = 0;
                }
            }

            // left column
            for(int i = bottom - 1; i >= top + 1; i--) {

                grid[i][left] = vals[idx];

                idx++;

                if(idx == sz) {
                    idx = 0;
                }
            }
        }

        return grid;
    }
}
