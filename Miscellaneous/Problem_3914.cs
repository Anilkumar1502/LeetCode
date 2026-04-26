public class Solution {
    public long MinOperations(int[] nums) {

        long res=0;
        long prev=nums[0];

        for(int i=1;i<nums.Length;i++){

            if(prev>(res+nums[i])){
                res+=prev-(res+nums[i]);               
            }
            prev=nums[i]+res;
        }

        return res;
    }
}
