public class Solution {
    public int MaxSubarrayLength(int[] nums, int k) {
        
        int n=nums.Length;

        Dictionary<int,int> freq=new();

        int j=0;
        int max=1;
        for(int i=0;i<n;i++){
            int key=nums[i];

            if(!freq.ContainsKey(key)){
                freq[key]=0;
            }
            freq[key]+=1;
            while(freq[key]>k){
                int bkey=nums[j];
                int val=freq[bkey]-=1;
                j+=1;
            }
            max=Math.Max(max,i-j+1);
        }
        return max;
    }
}
