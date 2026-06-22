public class Solution {
    public int LargestAltitude(int[] gain) {
        int max=0;
        int sum=0;
        foreach(int g in gain){
            sum+=g;
            max=Math.Max(max,sum);
        }

        return max;
    }
}
