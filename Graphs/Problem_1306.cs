public class Solution {
    public bool CanReach(int[] arr, int start) {
        
        int n=arr.Length;
        bool[] visit=new bool[n];

        Queue<int> q=new();

        q.Enqueue(start);

        while(q.Count>0){
            int cnt=q.Count;

            while(cnt>0){
                int idx=q.Dequeue();
                visit[idx]=true;
                if(arr[idx]==0)
                return true;
                
                int left=idx-arr[idx];
                int right=idx+arr[idx];
                if(left>=0&&!visit[left]){
                    q.Enqueue(left);
                }
                if(right<n&&!visit[right]){
                    q.Enqueue(right);
                }
                cnt-=1;
            }
        }
        return false;
    }
}
