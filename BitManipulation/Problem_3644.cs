public class Solution {
    public int SortPermutation(int[] nums) {
        int res=-1;
        for(int i=0;i<nums.Length;i++){
            if(nums[i]!=i){
                if(res==-1){
                    res=nums[i];
                }
                else{
                    res=res&nums[i];
                }
            }
        }
        return (res==-1)?0:res;
    }
}
