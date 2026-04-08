public class Solution {
    public int XorAfterQueries(int[] nums, int[][] queries) {
        
        long MOD=1000_000_007L;

        for(int i=0;i<queries.Length;i++){
            int[] query=queries[i];

            for(int j=query[0];j<=query[1];j+=query[2]){
                nums[j]=(int)(1L*nums[j]*query[3]%MOD);
            }
        }

        int result=0;
        foreach(var num in nums){
            result=result^num;
        }
        return result;
    }
}
