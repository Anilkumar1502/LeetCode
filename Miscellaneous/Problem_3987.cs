public class Solution {
    public int MinimumCost(int[] nums, int k) {

        long MOD=1000_000_007L;

        long sum=0;
        foreach(int num in nums){
            sum+=num;
        }

        long lk=1L*k;
        long d=sum/lk;

        if(sum%lk==0){
            d-=1;
        }

        long rev=500000004;
        long total=((((d%MOD)*((d+1)%MOD))%MOD)*rev)%MOD;

        

        return (int)(total%MOD);
    }
}
