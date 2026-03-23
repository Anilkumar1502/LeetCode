public class Solution {
    public int MaxProductPath(int[][] grid) {
        
      int m =grid.Length;
      int n=grid[0].Length;
      long MOD=1000000007;

      (long,long)[][] bfs=new (long,long)[m][];

      for(int i=0;i<m;i++){
        bfs[i]=new (long,long)[n];
      }

      
          
      long prod=grid[0][0];
      bfs[0][0]=(prod,prod);
      for(int i=1;i<m;i++){
        prod*=grid[i][0];
        bfs[i][0]=(prod,prod);
      }

      prod=grid[0][0];
      for(int i=1;i<n;i++){
        prod*=grid[0][i];
        bfs[0][i]=(prod,prod);
      }

  
      for(int i=1;i<m;i++){
        for(int j=1;j<n;j++){
            int num=grid[i][j];
            (long tmin,long tmax) =bfs[i-1][j];
            (long lmin,long lmax) =bfs[i][j-1];

           if(grid[i][j]<0){
             long min=Math.Min(tmax*num,lmax*num);
             long max=Math.Max(tmin*num,lmin*num);
             bfs[i][j]=(min,max);
           }
           else{
            long min=Math.Min(tmin*num,lmin*num);
            long max=Math.Max(tmax*num,lmax*num);
            bfs[i][j]=(min,max);
           }

        }
      }
      
       (long fmin,long fmax)=bfs[m-1][n-1];
       if(fmax<0)
       return -1;

      return (int)(fmax%MOD);
    }
}
