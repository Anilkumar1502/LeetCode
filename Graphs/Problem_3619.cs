public class Solution {
    public int CountIslands(int[][] grid, int k) {
       // return 0;
       int m=grid.Length;
       int n=grid[0].Length;
       int res=0;
       for(int i=0;i<m;i++){
         for(int j=0;j<n;j++){
            if(grid[i][j]==0)
            continue;
            long sum=DFS(i,j,grid);
            if(sum%k==0){
                res+=1;
            }
         }
       }
       return res;
    }


    private long DFS(int x,int y,int[][] g){
        if(x<0||y<0||x==g.Length||y==g[0].Length)
        return 0;

        if(g[x][y]==0)
        return 0;

        
        long sum=g[x][y];
        g[x][y]=0;
        long u=DFS(x-1,y,g);
        long d=DFS(x+1,y,g);
        long l=DFS(x,y-1,g);
        long r=DFS(x,y+1,g);


        return sum+u+d+l+r;

    }
}
