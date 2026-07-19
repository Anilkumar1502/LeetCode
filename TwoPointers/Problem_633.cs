public class Solution {
    public bool JudgeSquareSum(int c) {
        
        if(c==0)
        return true;

        if(c%4==3)
        return false;

        long low=0;
        long high=(long)Math.Sqrt(c);
        long t=1L*c;
        while(low<=high){

            long val=low*low+high*high;
            if(val>t){
                high-=1;
            }
            else if(val<t){
                low+=1;
            }
            else
             return true;
        }

        return false;
    }
}
