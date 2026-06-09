public class Solution {
    public bool CheckSubarraySum(int[] nums, int k) {
        
        Dictionary<int,int> dict=new();

        dict[0]=-1;
        int sum=0;
        for(int i=0;i<nums.Length;i++){
            sum+=nums[i];
            sum%=k;
            bool hasRem=dict.ContainsKey(sum);
            if(hasRem&&i>1+dict[sum]){
                return true;
            }
            if(!hasRem)
            dict[sum]=i;
        }
        return false;
    }
}
