public class Solution {
    public int MaxProfit(int[] prices) {
        
        long ti10=0;
        long ti11=int.MinValue;
        long ti20=0;
        long ti21=int.MinValue;

        for(int i=0;i<prices.Length;i++){
            ti11=Math.Max(ti11,-prices[i]);
            ti10=Math.Max(ti10,ti11+prices[i]);
            ti21=Math.Max(ti21,ti10-prices[i]);
            ti20=Math.Max(ti20,ti21+prices[i]);
        }

        return (int)Math.Max(ti10,ti20);
    }
}
