public class Solution {
    public int MaxDistance(int[] nums1, int[] nums2) {
        
        int m=nums1.Length;
        int n=nums2.Length;

        int i=0;
        int j=0;

        int max=0;
        while(i<m&&j<n){
           
            if(nums1[i]<=nums2[j]){
                max=Math.Max(max,j-i);
                j+=1;
            }
            else{
                i+=1;
            }

        }
        return max;
    }
}
