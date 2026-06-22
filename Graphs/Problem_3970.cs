public class Solution {

    
    public int ShortestPath(int n, int[][] edges, string labels, int k) {

        if(n==1)
            return 0;

        PriorityQueue<(int,int,int),int> pq=new();
        
        bool[] visit=new bool[n];
        List<List<(int v,int w) >> adj=new();
        for(int i=0;i<n;i++){
            adj.Add(new());
        }
   
        for(int i=0;i<edges.Length;i++){
            int[] e=edges[i];
            int u=e[0];
            int v=e[1];
            int w=e[2];
            adj[u].Add((v,w));

        }
        pq.Enqueue((0,1,0),0);

        int[][] dp=new int[n][];
        for(int i=0;i<n;i++){
         dp[i]=new int[k+1];
         Array.Fill(dp[i],int.MaxValue);
        }

        while(pq.Count>0){
            (int idx,int cnt,int wt)=pq.Dequeue();
            List<(int,int)> edgs=adj[idx];

            // if(idx==n-1)
            // return wt;

            // if(visit[idx])
            // continue;

           // visit[idx]=true;
            foreach(var e in edgs){
                (int v,int w)=e;
                // if(visit[v])
                // continue;

                char c=labels[v];
                int nc=(c==labels[idx])?cnt+1:1;

                if(nc>k)
                continue;

                int tw=wt+w;
                if(dp[v][nc]>tw){
                    dp[v][nc]=tw;
                    pq.Enqueue((v,nc,tw),tw);
                }
 
            }
        }
        int min=int.MaxValue;

        for(int i=0;i<=k;i++){
            min=Math.Min(min,dp[n-1][i]);
        }

        return (min==int.MaxValue)?-1:min;

    }

}
