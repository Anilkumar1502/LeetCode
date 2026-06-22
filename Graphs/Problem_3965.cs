public class Solution {
    public long FinishTime(int n, int[][] edges, int[] bt) {

        if(n==1)
            return bt[0];
        
        List<List<int>> adj=new();

        for(int i=0;i<n;i++){
            adj.Add(new());
        }

        for(int i=0;i<edges.Length;i++){
            int u=edges[i][0];
            int v=edges[i][1];

            adj[u].Add(v);
            adj[v].Add(u);
        }
        bool[] visit=new bool[n];

        return DFS(0,-1,visit,adj,bt);
    }

    private long DFS(int idx,int pnt,bool[] v,List<List<int>> adj,int[] b){

        // if(adj[idx].Count==1)
        //     return b[idx];

        v[idx]=true;

        List<int> edges=adj[idx];

        long min=long.MaxValue;
        long max=long.MinValue;
        int s=-1;
        for(int i=0;i<edges.Count;i++){
            int edge=edges[i];
            if(edge==pnt)
                continue;

            s=0;
            long r=DFS(edge,idx,v,adj,b);
            min=Math.Min(r,min);
            max=Math.Max(r,max);
        }

        if(s==-1)
            return b[idx];
        
        long ownD=max-min+b[idx];
        return max+ownD;
    }
}
