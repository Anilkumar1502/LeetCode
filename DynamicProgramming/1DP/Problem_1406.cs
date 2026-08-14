public class Solution {
    public string StoneGameIII(int[] stoneValue) {
        
        int n=stoneValue.Length;
        int[] dp=new int[n];
        Array.Fill(dp,int.MinValue);
        int res= DP(0,dp,stoneValue);

        if(res<0)
        return "Bob";
        else if(res>0)
        return "Alice";
        return "Tie";
    }

    private int DP(int idx,int[] dp,int[] st){

        if(idx==dp.Length)
        return 0;

        if(dp[idx]!=int.MinValue)
        return dp[idx];

        int n=dp.Length;
        int max=int.MinValue;
        int val=st[idx]-DP(idx+1,dp,st);
        max=Math.Max(max,val);
        if(idx<n-1)
        max=Math.Max(max,st[idx]+st[idx+1]-DP(idx+2,dp,st));
        if(idx<n-2)
        max=Math.Max(max,st[idx]+st[idx+1]+st[idx+2]-DP(idx+3,dp,st));

        return dp[idx]=max;
    }
}
