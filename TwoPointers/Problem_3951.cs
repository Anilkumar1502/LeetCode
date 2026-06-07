public class Solution {
    public long MinEnergy(int n, int brightness, int[][] intervals) {

        Array.Sort(intervals,(a,b)=>{
            return a[0]-b[0];
        });

        int m=intervals.Length;

        long ttl=0;
        for(int i=0;i<m;i++){

            int o=intervals[i][0];
            int e=intervals[i][1];

            while(i<m&&e>=intervals[i][0]){
                e=Math.Max(e,intervals[i][1]);
                i+=1;
            }
       
            i-=1;            
            ttl+=e-o+1;
        }

        long t=(brightness%3==0)?0:1;
        t+=brightness/3;
        return t*ttl;
    }
}
