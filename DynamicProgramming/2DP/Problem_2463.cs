public class Solution {
    public long MinimumTotalDistance(IList<int> robot, int[][] factory) {
        
        int m=robot.Count;
        int n=factory.Length;

        int[] robots=new int[m];
        for(int i=0;i<m;i++){
            robots[i]=robot[i];
        }

        Array.Sort(robots);

        Array.Sort(factory,(a,b)=>a[0]-b[0]);

        long[][] dp=new long[m+1][];
        long INF=(long)(Math.Pow(2,53)-1);
        for(int i=0;i<=m;i++){
            dp[i]=new long[n+1];
        }
        for(int i=0;i<=m;i++){
            for(int j=0;j<=n;j++)
            {  
                dp[i][j]=INF;
            }
        }

        for(int j=0;j<=n;j++){
            dp[0][j]=0;
        }


        for(int j=1;j<=n;j++){
            
            int pos=factory[j-1][0];
            int limit=factory[j-1][1];

            for(int i=1;i<=m;i++){
                dp[i][j] = dp[i][j-1];  //if factory is skipped.
                long distance=0;
                for(int k=1;k<=limit&&k<=i;k++){
                    distance+=Math.Abs(robots[i-k]-pos);
                    dp[i][j]=Math.Min(dp[i][j],distance+dp[i-k][j-1]);
                }
            }
        }
        return dp[m][n];

    }
}
