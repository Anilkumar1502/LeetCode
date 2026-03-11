public class Solution {
    public int MinPathSum(int[][] grid) {
        
        int m=grid.Length;
        int n=grid[0].Length;

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(i==0&&j==0)
                continue;

                int top=(i==0)?int.MaxValue:grid[i-1][j];
                int left=(j==0)?int.MaxValue:grid[i][j-1];
 
               
                grid[i][j]+=Math.Min(top,left);
            }
        }

        return grid[m-1][n-1];
    }
}
