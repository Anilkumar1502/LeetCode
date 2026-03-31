public class Solution {
    public int MaxProfit(int[] prices, int fee) {
        
        long tik0=0;
        long tik1=int.MinValue;

        for(int i=0;i<prices.Length;i++){
            tik1=Math.Max(tik1,tik0-prices[i]);
            tik0=Math.Max(tik0,tik1+prices[i]-fee);
        }

        return (int)tik0;
    }
}
