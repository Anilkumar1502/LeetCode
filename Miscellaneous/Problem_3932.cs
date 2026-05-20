public class Solution {
    public int CountKthRoots(int l, int r, int k) {

        if(k==1)
        return r-l+1;

        long left=1L*l;
        long right=1L*r;
        int count=0;
        for(long i=0;i<=right;i++){

            long pv=FindPower(i,k);

            if(pv>=left&&pv<=right){
                count+=1;
            }
            if(pv>right)
            break;
        }
        return count;
    }

    private long FindPower(long v,int k){

        if(k==0)
        return 1;

        long value=FindPower(v,k/2);
        if(k%2==1){
            return value*value*v;
        }
        else{
            return value*value;
        }
    }
}
