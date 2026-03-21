public class Solution {
    public int FindMin(int[] nums) {

     int low=0;
     int high=nums.Length-1;

     if(nums[low]<=nums[high])
     return nums[low];

     while(low<high){
        int mid=low+(high-low)/2;
        if(high==low+1)
        return Math.Min(nums[low],nums[high]);
        
        if(nums[mid]<nums[low]){
           high=mid;
        }
        else{
           low=mid;
        }
     }
     return -1;   
    }
}
