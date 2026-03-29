public class Solution {
    public int MinAbsoluteDifference(int[] nums) {

        int abs=101;

        int oidx=-1;
        int tidx=-1;

        for(int i=0;i<nums.Length;i++){

            if(nums[i]==1){
                oidx=i;
                if(tidx!=-1){
                    abs=Math.Min(abs,Math.Abs(tidx-oidx));
                }
            }
            else if(nums[i]==2){
                tidx=i;
                if(oidx!=-1){
                    abs=Math.Min(abs,Math.Abs(tidx-oidx));
                }
            }
        }

        return (abs==101)?-1:abs;
    }
}
