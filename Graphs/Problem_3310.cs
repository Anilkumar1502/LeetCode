public class Solution {
    public IList<int> RemainingMethods(int n, int k, int[][] invocations) {
        
        bool[] same=new bool[n];

        List<List<int>> adj=new List<List<int>>();

        for(int i=0;i<n;i++){
            adj.Add(new List<int>());
        }
        foreach(int[] inv in invocations){
            adj[inv[0]].Add(inv[1]);
        }

        DFS(k,adj,same);

        bool remove=true;
        for(int i=0;i<n;i++){
            if(same[i])
            continue;

            List<int> edges=adj[i];
            foreach(int e in edges){
                if(same[e]){
                    remove=false;
                    break;
                }
            }
        }

        IList<int> remaining=new List<int>();
        for(int i=0;i<n;i++){
            if(!remove){
                remaining.Add(i);
                continue;
            }
            if(!same[i]){
                remaining.Add(i);
            }
        }
        return remaining;
    }

    private void DFS(int u,List<List<int>> adj,bool[] s){
        if(s[u])
        return;

        s[u]=true;

        List<int> edges=adj[u];
        foreach(int e in edges){
            if(s[e])
            continue;

            DFS(e,adj,s);
        }
    }
}
