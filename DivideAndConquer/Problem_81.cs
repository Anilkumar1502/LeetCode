public class Solution {
    public bool Search(int[] nums, int target) {

     int low=0;
     int high=nums.Length-1;

     while(low<=high){
        int mid=low+(high-low)/2;
       // Console.WriteLine(mid);
        if(nums[low]==target||nums[mid]==target||nums[high]==target){
            return true;
        }
        
        if(nums[low]==nums[high]){
            low+=1;
            high-=1;
            continue;
        }

        if(nums[mid]<nums[high]){
            if(nums[mid]<target&&nums[high]>=target){
                low=mid+1;
            }
            else{
                high=mid-1;
            }
        }
        else if(nums[mid]>nums[high]){
            if(nums[low]<=target&&nums[mid]>target){
                high=mid-1;
            }
            else{
                low=mid+1;
            }
        }
        else{
            low+=1;
        }
        
     }

     return false;   
    }
}
