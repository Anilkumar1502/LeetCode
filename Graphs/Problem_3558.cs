public class Solution {
    public int AssignEdgeWeights(int[][] edges) {
        
        long MOD=1000_000_007;

        List<List<int>> adj=new();
        int n=edges.Length+1;

        for(int i=0;i<=n;i++){
            adj.Add(new());
        }

        foreach(var edge in edges){
            int u=edge[0];
            int v=edge[1];

            adj[u].Add(v);
            adj[v].Add(u);
        }

        Queue<int> bfs=new();
        long dpt=1;
        int level=0;
        bfs.Enqueue(1);
        bool[] visited=new bool[n+1];
        while(bfs.Any()){
            int cnt=bfs.Count;

            while(cnt>0){
                int v=bfs.Dequeue();
                visited[v]=true;
                List<int> edgs=adj[v];

                foreach(var e in edgs){
                    if(visited[e])
                    continue;

                    bfs.Enqueue(e);
                }

                cnt-=1;
            }
           level+=1;
           if(level>2){
            dpt<<=1;
            dpt=dpt%MOD;
           }
        //    Console.WriteLine(dpt);
        }

        
     //   dpt=dpt>>2;
        //Console.WriteLine(dpt);

        return (int)(dpt%MOD);





    }
}
