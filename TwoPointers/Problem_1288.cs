public class Solution {
    public int RemoveCoveredIntervals(int[][] intervals) {
        
        Array.Sort(intervals,(a,b)=>{
            if(a[0]==b[0])
            return b[1]-a[1];

            return a[0]-b[0];
        });

        int j=0;
        int cnt=1;
        int maxEnd=intervals[0][1];
        for(j=1;j<intervals.Length;j++){
            if(intervals[j][1]>maxEnd){
            maxEnd=intervals[j][1];
            cnt+=1;
            }
        }

        return cnt;
    }
}
