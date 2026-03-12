public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        
        int l=nums1.Length-1;
        m-=1;
        n-=1;

        while(m>=0&&n>=0){
            if(nums1[m]>nums2[n]){
              nums1[l]=nums1[m];
              nums1[m]=-1;
              m-=1;
            }
            else{
              nums1[l]=nums2[n]; 
              n-=1;
            }
            l-=1;
        }
        while(n>=0){
            nums1[l]=nums2[n];
            l-=1;
            n-=1;
        }
    }
}
