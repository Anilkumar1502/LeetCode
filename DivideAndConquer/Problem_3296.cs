public class Solution {
    public long MinNumberOfSeconds(int mountainHeight, int[] workerTimes) {
        int maxWorkerTime=workerTimes.Max();

        long low=1;
        long high=1L*maxWorkerTime*mountainHeight*(mountainHeight+1)/2;
        long ans=-1;
        
        while(low<=high){

            long mid=low+(high-low)/2;

            long val=0;
            for(int i=0;i<workerTimes.Length;i++){
                double k=(-1+(Math.Sqrt(1+8.0*mid/workerTimes[i])))/2.0;
                val+=(long)Math.Floor(k);
            }
           
            if(val>=mountainHeight){
               ans=mid;
               high=mid-1;
            }
            else{
               low=mid+1;
            }
        }
        return ans;
    }

}
