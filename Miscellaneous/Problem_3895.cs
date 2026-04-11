public class Solution {
    public int CountDigitOccurrences(int[] nums, int digit) {

        int frequency=0;

        for(int i=0;i<nums.Length;i++){
            int num=nums[i];

            while(num>0){
                if(num%10==digit){
                    frequency+=1;
                }
                num=num/10;
            }
        }
        return frequency;
    }
}
