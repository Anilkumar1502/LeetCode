public class Solution {
    public long MaximumValue(int n, int s, int m) {

        int t=n/2;
        if(n==1)
        return s;
        
        long res=0;
 
        res=s+1L*(m-1)*t + 1;
      
        return res;
    }
}
