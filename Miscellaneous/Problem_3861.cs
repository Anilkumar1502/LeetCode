public class Solution {
    public int MinimumIndex(int[] capacity, int itemSize) {

        int idx=capacity.Length;
        int min=int.MaxValue;

        for(int i=0;i<capacity.Length;i++){
            if(capacity[i]>=itemSize){
                if(min>capacity[i]){
                    min=capacity[i];
                    idx=i;
                }
            }
        }

        return (idx==capacity.Length)?-1:idx;
    }
}
