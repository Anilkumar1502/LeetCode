public class Solution {
    public long MaximumScore(int[] nums, string s) {
        
        int n=nums.Length;
        long sum=0;
        PriorityQueue<int,int> pq=new(Comparer<int>.Create((a,b)=>b-a));
        for(int i=0;i<n;i++){

            pq.Enqueue(nums[i],nums[i]);
            if(s[i]=='1'){
                sum+=pq.Dequeue();
            }
        }
        return sum;
    }
}
