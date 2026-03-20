public class Solution {
    public bool CheckEqualPartitions(int[] nums, long target) {

        double prod=1.0;
        int n=nums.Length;

        for(int i=0;i<n;i++){
            prod*=nums[i];
        }

       // Console.WriteLine(prod);
        if((long)Math.Sqrt(prod)!=target)
        return false;

        return BackTracking(nums,0,1L,target);
    }
    private bool BackTracking(int[] nums,int idx,long prod,long target){
        if(idx>=nums.Length)
        return false;
        

        if(prod==target)
        return true;

        return BackTracking(nums,idx+1,prod*nums[idx],target)|| BackTracking(nums,idx+1,prod,target);
        
    }
    
}
