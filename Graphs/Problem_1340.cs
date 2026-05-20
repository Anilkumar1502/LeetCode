public class Solution {
    public int MaxJumps(int[] arr, int d) {
        
        int n=arr.Length;
        List<List<int>> adj=new();

        for(int i=0;i<n;i++){
            adj.Add(new());
        }
        for(int i=0;i<n;i++){

            int left=i-1;
            int right=i+1;
            int temp=d;
            while(left>=0&&temp>0){
                if(arr[left]>=arr[i])
                break;

                adj[i].Add(left);
                left-=1;
                temp-=1;
            }
            temp=d;
            while(right<n&&temp>0){
                if(arr[right]>=arr[i])
                break;

                adj[i].Add(right);
                right+=1;
                temp-=1;
            }
        }

       int[] possible=new int[n];
       Array.Fill(possible,-1);
       for(int i=0;i<n;i++){
         if(possible[i]!=-1)
         continue;

         possible[i]=DFS(i,adj,possible,1);
       }

       return possible.Max();
    }

    private int DFS(int idx,List<List<int>> adj,int[] possible,int depth){

        if(possible[idx]!=-1)
        return possible[idx];

        
        int max=1;
        List<int> edges=adj[idx];
        foreach(var edge in edges){
           int wt= DFS(edge,adj,possible,depth+1);
           max=Math.Max(max,wt+1);
        
        }
        return possible[idx]=max;
    }

    
}
