public class Solution {
    public int MirrorDistance(int n) {
        
        int reverse_n=0;
        int origin_n=n;
        while(n>0){
            reverse_n=reverse_n*10+n%10;
            n=n/10;
        }
        return Math.Abs(origin_n-reverse_n);

    }
}
