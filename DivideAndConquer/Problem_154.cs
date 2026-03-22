public class Solution {
    public int FindMin(int[] nums) {
        
        int low=0;
        int high=nums.Length-1;
        
        if(nums[low]<nums[high])
        return nums[low];
        if(nums.Length==1)
        return nums[0];

        while(low<high){
            int mid=low+(high-low)/2;
           // Console.WriteLine($"{low} {high}");
            if(nums[low]<nums[high])
            return nums[low];
            if(high-low==1){
                return Math.Min(nums[high],nums[low]);
            }
            if(nums[mid]<nums[low]){
               high=mid;
            }
            else if(nums[mid]>nums[low]){
               low=mid;
            }
            else
            {
                low+=1;
            }
        }
        return -1;
    }
}
