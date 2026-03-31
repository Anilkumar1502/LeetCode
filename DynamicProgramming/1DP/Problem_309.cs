public class Solution {
    public int MaxProfit(int[] prices) {
        long tik0=0;
        long tik1=int.MinValue;

        long[] old=[0,0];
        for(int i=0;i<prices.Length;i++){
            old[0]=old[1];
            old[1]=tik0;
            tik0=Math.Max(tik0,tik1+prices[i]);
            tik1=Math.Max(tik1,old[0]-prices[i]);
        }

        return (int)tik0;
    }
}
