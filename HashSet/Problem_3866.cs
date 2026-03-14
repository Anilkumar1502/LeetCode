public class Solution {
    public int FirstUniqueEven(int[] nums) {
        Dictionary<int,int> freq=new();
        for(int i=0;i<nums.Length;i++){
            if(!freq.ContainsKey(nums[i]))
             freq[nums[i]]=0;
            freq[nums[i]]+=1;
        }

        for(int i=0;i<nums.Length;i++){
            if((nums[i]&1)==0){
                if(freq[nums[i]]==1)
                return nums[i];
            }
        }
        return -1;
    }
}
