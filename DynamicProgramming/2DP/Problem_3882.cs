public class Solution {
    public int MinCost(int[][] grid) {

        int m=grid.Length;
        int n=grid[0].Length;

        bool[] visited=new bool[1024];

        Queue<int>[][] res=new Queue<int>[m][];

        for(int i=0;i<m;i++){
            res[i]=new Queue<int>[n];
        }

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++)
             res[i][j]=new Queue<int>();
        }

        res[0][0].Enqueue(grid[0][0]);
        int z=grid[0][0];
        for(int i=1;i<m;i++){
            z=z^grid[i][0];
            res[i][0].Enqueue(z);
        }
        z=grid[0][0];
        for(int i=1;i<n;i++){
            z=z^grid[0][i];
            res[0][i].Enqueue(z);
        }


        for(int i=1;i<m;i++){
            for(int j=1;j<n;j++){

                Queue<int> top=res[i-1][j];
                Queue<int> left=res[i][j-1];

                int val=grid[i][j];

                HashSet<int> store=new();
                while(top.Count>0){
                    store.Add(top.Dequeue()^val);
                    //res[i][j].Enqueue(top.Dequeue()^val);
                }
                int cnt=left.Count;
                while(cnt>0){
                    int l=left.Dequeue();
                    store.Add(l^val);
                   // res[i][j].Enqueue(l^val);
                    left.Enqueue(l);
                    cnt-=1;
                }
                foreach(var key in store){
                    res[i][j].Enqueue(key);
                }
                
            }
        }


        Queue<int> q=res[m-1][n-1];

        int min=int.MaxValue;

        while(q.Count>0){
            min=Math.Min(min,q.Dequeue());
        }

        return min;
        
    }
}
