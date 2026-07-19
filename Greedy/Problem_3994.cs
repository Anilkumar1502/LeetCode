public class Solution {
    public int MinAdjacentSwaps(int[] nums, int a, int b) {
        long MOD=1000_000_007L;

        int n=nums.Length;
        int[] prefix=new int[n];

        int j=0;
        long swaps=0;
        for(int i=0;i<n;i++){
           if(nums[i]>=a){
            prefix[i]=j;
            continue;
           }
           swaps+=i-j;
           j+=1;
        }
        

        int t=j;
        for(int i=0;i<n;i++){
            if(nums[i]<a||nums[i]>b){
                continue;
            }
            int curr=i+t-prefix[i];
            
            swaps+=curr-j;
            j+=1;
        }

        return (int)(swaps%MOD);
    }
}
