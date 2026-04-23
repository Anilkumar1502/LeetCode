public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        
        if(k==0)
        return 0;
        int tail=0;

        int product=1;
        int total=0;
        for(int i=0;i<nums.Length;i++){

            product*=nums[i];

            while(product>=k&&tail<i){
                product=product/nums[tail];
                tail+=1;
            }
           
            if(product<k)
            total+=(i-tail+1);

        }
        return total;
    }
}
