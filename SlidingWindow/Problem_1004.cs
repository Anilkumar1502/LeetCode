public class Solution {
    public int LongestOnes(int[] nums, int k) {
        
        int n=nums.Length;


        int max=k;
        int subMax=0;
        int j=0;
        for(int i=0;i<n;i++){
            k-=(nums[i]+1)%2;           

            if(k>=0){
            subMax+=1;
            max=Math.Max(max,subMax);
            }
            while(k<0&&j<=i){
                if(nums[j]==0)
                k+=1;
                else
                subMax-=1;

                j+=1;                             
            }

        }
        return max;
    }
}
