public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        
        int n=nums.Length;
        int[] res=new int[n];
        int l=0;
        int r=n-1;
        for(int i=0;i<n;i++){
            if(nums[i]<pivot){
                res[l]=nums[i];
                l+=1;
            }
            if(nums[n-i-1]>pivot){
                res[r]=nums[n-i-1];
                r-=1;
            }
        }
        while(l<=r){
            res[l]=pivot;
            l+=1;
        }
        return res;
    }
}
