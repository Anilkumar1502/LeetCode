public class Solution {
    public bool PredictTheWinner(int[] nums) {
        
        int n=nums.Length;
        int[][] dp=new int[n][];
        for(int i=0;i<n;i++){
            dp[i]=new int[n];
            Array.Fill(dp[i],int.MinValue);
        }
        int res=DP(0,n-1,dp,nums);
        //Console.WriteLine(res);
        return (res>=0)?true:false;
    }

    private int DP(int idx,int sidx,int[][] dp,int[] nums){
        if(idx==dp.Length||sidx<0)
        return 0;
        if(idx==sidx)
        return nums[idx];


        if(dp[idx][sidx]!=int.MinValue)
        return dp[idx][sidx];

        int max=int.MinValue;

        max=Math.Max(max,nums[idx]-DP(idx+1,sidx,dp,nums));
        max=Math.Max(max,nums[sidx]-DP(idx,sidx-1,dp,nums));

   

        return dp[idx][sidx]=max;
        
    }
}
