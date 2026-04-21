public class Solution {
    public int MinimumHammingDistance(int[] source, int[] target, int[][] allowedSwaps) {
        
        int n=source.Length;
        

        List<List<int>> adj=new();
        for(int i=0;i<n;i++)
        adj.Add(new());


        for(int i=0;i<allowedSwaps.Length;i++){
            int[] edge=allowedSwaps[i];
            int u=edge[0];
            int v=edge[1];
            adj[u].Add(v);
            adj[v].Add(u);
        }

        Dictionary<int,Dictionary<int,int>> ccn=new();
        bool[] visited=new bool[n];
        for(int i=0;i<n;i++){
            if(visited[i])
            continue;
            Dictionary<int,int> hset=new();
            DFS(adj,i,-1,source,visited,hset,ccn);          
        }
        int res=0;
        for(int i=0;i<n;i++){
            var ccns=ccn[i];
            int tgt=target[i];
            int src=source[i];
            if(ccns.ContainsKey(tgt)&&ccns[tgt]>0){
                ccns[tgt]-=1;               
                continue;
            }
            res+=1;
            
        }

        return res;
        
    }

    private void DFS(List<List<int>> adj,int u,int v,int[] source,bool[] visit,Dictionary<int,int> ccn,    Dictionary<int,Dictionary<int,int>> ccnd){

        if(visit[u])
        return;

        visit[u]=true;
        ccnd[u]=ccn;
        if(!ccn.ContainsKey(source[u])){
            ccn[source[u]]=new();
        }
        ccn[source[u]]+=1;



        var edges=adj[u];

        foreach(var edge in edges){
            if(edge!=v){
                DFS(adj,edge,u,source,visit,ccn,ccnd);
            }
        }
    }
}
