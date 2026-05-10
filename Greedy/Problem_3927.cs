public class Solution {
    public long MinArraySum(int[] nums) {

        int max=-1;

        int n=nums.Length;
        for(int i=0;i<nums.Length;i++){
            max=Math.Max(max,nums[i]);
        }

        bool[] isPresent=new bool[max+1];
        foreach(var num in nums)
        isPresent[num]=true;

        int[] minDiv=new int[max+1];

        for(int i=1;i<=max;i++){
            if(isPresent[i]){
                for(int j=i;j<=max;j+=i){
                    if(minDiv[j]==0){
                        minDiv[j]=i;
                    }
                }
            }
        }

        long sum=0;
        foreach(var num in nums){
            sum+=minDiv[num];
        }

        return sum;
    }
}
