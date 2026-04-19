public class Solution {
    public int[][] ColorGrid(int n, int m, int[][] sources) {
        
        (n,m)=(m,n);
        int[][] arr=new int[m][];
        bool[][] visited=new bool[m][];

        for(int i=0;i<m;i++){
            arr[i]=new int[n];
            visited[i]=new bool[n];
        }

        Queue<(int x,int y)> bfs=new();
        for(int i=0;i<sources.Length;i++){
           int r=sources[i][0];
           int c=sources[i][1];
           int color=sources[i][2];

           visited[r][c]=true;
           bfs.Enqueue((r,c));
           arr[r][c]=color;
        }

        Dictionary<(int x,int y),int> maxColor=new();
        while(bfs.Any()){
            int cnt=bfs.Count;
            maxColor.Clear();
            while(cnt>0){
                (int x,int y)=bfs.Dequeue();
                
                if(x>=1&&arr[x-1][y]==0){

                    UpdateDictionary(maxColor,arr[x][y],x-1,y);
                    if(!visited[x-1][y]){
                     bfs.Enqueue((x-1,y));
                     visited[x-1][y]=true;
                    }
                }

                if(x<m-1&&arr[x+1][y]==0){
                    UpdateDictionary(maxColor,arr[x][y],x+1,y);
                    if(!visited[x+1][y]){
                     bfs.Enqueue((x+1,y));
                     visited[x+1][y]=true;
                    }
                }
                if(y>=1&&arr[x][y-1]==0){
                    UpdateDictionary(maxColor,arr[x][y],x,y-1);
                    if(!visited[x][y-1]){
                     bfs.Enqueue((x,y-1));
                     visited[x][y-1]=true;
                    }
                }
                if(y<n-1&&arr[x][y+1]==0){
                     UpdateDictionary(maxColor,arr[x][y],x,y+1);
                    if(!visited[x][y+1]){
                     bfs.Enqueue((x,y+1));
                     visited[x][y+1]=true;
                    }
                }
                cnt-=1;
            }

            foreach(var keyValue in maxColor){
                arr[keyValue.Key.x][keyValue.Key.y]=keyValue.Value;
            }
        }

        return arr;
    }

    private void UpdateDictionary(Dictionary<(int,int),int> max,int val,int x,int y){
        if(max.ContainsKey((x,y))){
            max[(x,y)]=Math.Max(max[(x,y)],val);
        }
        else{
            max[(x,y)]=val;
        }
    }
}
