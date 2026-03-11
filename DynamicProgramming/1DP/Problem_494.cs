public class Solution {

    int ways=0;
    public int FindTargetSumWays(int[] nums, int target) {
        int sum=0;
        foreach(int num in nums)
            sum += num;
        if(sum < Math.Abs(target) ||(sum + target) % 2 != 0)
            return 0;
       // BackTracking(nums,target,0,0);
        int newTarget = (sum - target) / 2;
        Span<int> dp = stackalloc int[newTarget + 1];
        dp[0] = 1;
        foreach(int num in nums)
        {
            for(int i = newTarget; i >= num; i--)
            {
                dp[i] += dp[i-num];
            }
        }
        return dp[newTarget];
    }    
}
