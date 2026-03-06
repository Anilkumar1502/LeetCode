public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        
        int[] res={-1,-1};
        int high=nums.Length-1;
        res[0]=BinarySearch(nums,target,0,high,true);
        res[1]=BinarySearch(nums,target,0,high,false);
        return res;
    }

    private int BinarySearch(int[] nums,int t,int l,int h,bool lowBnd){
       
       int res=-1;
       while(l<=h){
        int mid=l+(h-l)/2;
        if(nums[mid]==t){
            res=mid;
           if(lowBnd){
            h=mid-1;
           }
           else{
            l=mid+1;
           }
        }
        else if(nums[mid]>t){
            h=mid-1;
        }
        else if(nums[mid]<t){
            l=mid+1;
        }

       }
       return res;
    }
}
