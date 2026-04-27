public class Solution {
    public bool HasValidPath(int[][] grid) {
        
        int m=grid.Length;
        int n=grid[0].Length;
        bool[][] visit=new bool[m][];
        for(int i=0;i<m;i++)
            visit[i]=new bool[n];

        DFS(0,0,m,n,grid,visit,0,0,'k');
        // for(int i=0;i<m;i++){
        //     for(int j=0;j<n;j++){
        //         Console.Write($"{visit[i][j]} ");
        //     }
        //     Console.WriteLine();
        // }
        return visit[m-1][n-1];
    }

    private void DFS(int i,int j,int m,int n,int[][] g,bool[][] v,int pi,int pj,char d){
        if(i<0||i>=m||j<0||j>=n)
        return;

        if(v[i][j])
        return;

        //Console.Write($" {g[pi][pj]} - {g[i][j]} - {i} {j}");
        if(g[i][j]==1){

            if(d=='k'||g[pi][pj]==1||d=='l'||d=='r'){
            v[i][j]=true;
            DFS(i,j-1,m,n,g,v,i,j,'l');
            DFS(i,j+1,m,n,g,v,i,j,'r');
            }
        }
        else if(g[i][j]==2){

            if(d=='k'||g[pi][pj]==2||d=='t'||d=='b'){
            v[i][j]=true;
            DFS(i-1,j,m,n,g,v,i,j,'t');
            DFS(i+1,j,m,n,g,v,i,j,'b');
            }
        }
        else if(g[i][j]==3){
            if(d=='k'||d=='r'||d=='t'){
            v[i][j]=true;
            DFS(i+1,j,m,n,g,v,i,j,'b');
            DFS(i,j-1,m,n,g,v,i,j,'l');
           }
        }
        else if(g[i][j]==4){   
           if(d=='k'||d=='t'||d=='l'){  
            v[i][j]=true;
            DFS(i,j+1,m,n,g,v,i,j,'r');
            DFS(i+1,j,m,n,g,v,i,j,'b');
           }
        }
        else if(g[i][j]==5){
            if(d=='k'||d=='r'||d=='b'){
            v[i][j]=true;
            DFS(i,j-1,m,n,g,v,i,j,'l');
            DFS(i-1,j,m,n,g,v,i,j,'t');
           }
        }
        else if(g[i][j]==6){
            if(d=='k'||d=='b'||d=='l'){
            v[i][j]=true;
            DFS(i-1,j,m,n,g,v,i,j,'t');
            DFS(i,j+1,m,n,g,v,i,j,'r');
            }
        }
    }
}
