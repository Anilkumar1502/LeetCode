public class Solution {
    public int SmallestBalancedIndex(int[] nums) {

        int n=nums.Length;
        long[] preSum=new long[n];
        long[] sProd=new long[n];

        long sum=0;
        long prod=1;
        for(int i=0;i<n;i++){
            preSum[i]=sum;
            sum+=nums[i];

            sProd[n-i-1]=prod;            
            prod*=nums[n-i-1];
            if(prod<0)
            prod=-1;
        }
      
        for(int i=0;i<n;i++){         
            if(preSum[i]==sProd[i])
            return i;
        }
        return -1;
        
    }
}
