public class Solution {
    public int ClosedIsland(int[][] grid) {
        
        int m=grid.Length;
        int n=grid[0].Length;
        int total=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]==0){
                   bool isIsland= DFS(i,j,grid);
                   if(isIsland){
                     total+=1;
                   }
                }
            }
        }

        return total;

    }
    private bool DFS(int x,int y,int[][] g){
        if(x<0||x>=g.Length||y<0||y>=g[0].Length)
        return false;

        if(g[x][y]==1)
        return true;

        g[x][y]=1;

        bool d= DFS(x+1,y,g);
        bool u=DFS(x-1,y,g);
        bool r=DFS(x,y+1,g);
        bool l=DFS(x,y-1,g);

        return d&&u&&r&&l;
    }
}
