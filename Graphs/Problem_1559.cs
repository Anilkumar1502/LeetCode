public class Solution {
    public bool ContainsCycle(char[][] grid) {
    
        int m=grid.Length;
        int n=grid[0].Length;

        bool[][] visit=new bool[m][];
        for(int i=0;i<m;i++){
            visit[i]=new bool[n];
        }

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(visit[i][j])
                continue;

                bool valid=DFS(i,j,m,n,visit,grid,grid[i][j],-1,-1,-1);
              // Console.WriteLine($"{i} {j}");
                if(valid)
                return true;
            }
        }
        return false;
    }

    private bool DFS(int i,int j,int m,int n,bool[][] visit,char[][] g,char c,int d,int pi,int pj){
        if(i<0||i>=m||j<0||j>=n)
        return false;

        if(g[i][j]!=c)
        return false;

     //  
        if(visit[i][j]&&!(pi==i && pj==j)){  
          //   Console.WriteLine($"{pi} {i} - {pj} {j}");
            return true;
        }
        if(visit[i][j])
        return false;

        //
        visit[i][j]=true;
        bool btm=false;
        bool tp=false;
        bool rt=false;
        bool lt=false;
        if(d!=2)
        btm=DFS(i+1,j,m,n,visit,g,c,1,i,j);

        if(btm)
        return true;

        if(d!=1)
        tp=DFS(i-1,j,m,n,visit,g,c,2,i,j);

        if(tp)
        return true;

        if(d!=4)
        rt=DFS(i,j+1,m,n,visit,g,c,3,i,j);

        if(rt)
        return true;

        if(d!=3)
        lt=DFS(i,j-1,m,n,visit,g,c,4,i,j);

        if(lt)
        return true;

        return btm||tp||rt||lt;
    }
}
