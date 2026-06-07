public class Solution {
    public bool ConsecutiveSetBits(int n) {
        int cnt=0;

        int prev=-1;
        while(n>0){
            int curr=n&1;
            if(prev==1&&curr==1){
                cnt+=1;
            }
            prev=curr;
            n/=2;
            if(curr>1)
            return false;
        }

        return cnt==1?true:false;
    }
}
