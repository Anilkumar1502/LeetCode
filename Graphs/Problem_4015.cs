    public class Solution {
        int maxh=0;
        public long WeightedSum(int[] parent, int[] nums) {

            long w=0;

            List<List<int>> adj=new();

            int n=parent.Length;

            for(int i=0;i<n;i++){
                adj.Add(new());
            }

            for(int i=1;i<n;i++){
                int u=parent[i];
                adj[u].Add(i);
            }

            DFS(0,adj,1);

            Queue<int> bfs=new();
            bfs.Enqueue(0);
            int level=1;
        // Console.WriteLine(maxh);
            while(bfs.Count>0){
                int cnt=bfs.Count;
                while(cnt>0){
                    int v=bfs.Dequeue();
                    w+=1L*nums[v]*(maxh-level+1);
                    List<int> edg=adj[v];
                    foreach(int e in edg){
                        bfs.Enqueue(e);
                    }
                    cnt-=1;
                }
                level+=1;
            }
            return w;
        }

        private void DFS(int idx,List<List<int>> adj,int h){

            List<int> edg=adj[idx];
            maxh=Math.Max(h,maxh);
            if(edg.Count==0)
            return;

            foreach(int u in edg){
                DFS(u,adj,h+1);
            }
        }
    }
