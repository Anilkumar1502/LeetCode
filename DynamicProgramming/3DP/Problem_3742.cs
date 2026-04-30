public class Solution {
    public int MaxPathScore(int[][] grid, int k) {
        
        int m=grid.Length;
        int n=grid[0].Length;
     

        int[][][] dp=new int[m][][];
        for(int i=0;i<m;i++)
            dp[i]=new int[n][];

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                dp[i][j]=new int[k+1];
                Array.Fill(dp[i][j],-1);
            }
        }

        dp[0][0][0]=0;
        


        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                   int val=grid[i][j];
                   int cost=(grid[i][j]==0)?0:1;
                   for(int c=0;c<=k;c++){

                         

                        int nc=cost+c;
                        if(i>=1&&nc<=k&&dp[i-1][j][c]!=-1){
                            
                           dp[i][j][nc] = Math.Max(dp[i-1][j][c]+val,dp[i][j][nc]);
                        }

                        if(j>=1&&nc<=k&&dp[i][j-1][c]!=-1){
                           
                             dp[i][j][nc] = Math.Max(dp[i][j-1][c]+val,dp[i][j][nc]);
                        }
                   }
            }
        }
        int max=-1;
        for(int i=0;i<=k;i++){
            max=Math.Max(max,dp[m-1][n-1][i]);
        }
        return max;
       
    }
     
}
