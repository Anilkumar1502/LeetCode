public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        int prev=0;

        for(int i=1;i<nums.Length;i++){
             if(nums[i]==nums[prev])
             continue;

             prev+=1;
             nums[prev]=nums[i];
        }
        return prev+1;
    }
}
