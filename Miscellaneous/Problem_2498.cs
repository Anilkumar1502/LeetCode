public class Solution {
    public int MaxJump(int[] stones) {
        
        int max=stones[1]-stones[0];

        for(int i=2;i<stones.Length;i++){
            max=Math.Max(max,stones[i]-stones[i-2]);
        }
        return max;
    }
}
