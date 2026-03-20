public class Solution {
    public int CountSubmatrices(int[][] grid, int k) {

        int m=grid.Length;
        int n=grid[0].Length;

        for(int i=1;i<m;i++){
            for(int j=0;j<n;j++){
                grid[i][j]+=grid[i-1][j];
            }
        }

        int sum=0;
        int cnt=0;
        for(int i=0;i<m;i++){
            sum=0;
            for(int j=0;j<n;j++){
                sum+=grid[i][j];
                if(sum<=k){
                    cnt+=1;
                }
            }
        }
        return cnt;
    }
}
