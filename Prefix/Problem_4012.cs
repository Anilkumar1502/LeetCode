public class Solution {
    public int[] CountTasks(int[] tasks, int[] shifts) {
        
        int n=tasks.Length;
        long[] prefix=new long[n];

        prefix[0]=tasks[0];
        for(int i=1;i<n;i++){
            prefix[i]=prefix[i-1]+tasks[i];
        }

        int m=shifts.Length;
        int[] ans=new int[m];
        long temp=0;
        for(int i=0;i<m;i++){
            long target=temp+shifts[i];
            int idx=FindUpperBound(prefix,target);
            if(idx==-1){
                temp=0;
                continue;
            }
            temp=target;
            ans[i]=n-idx;
        }
        return ans;
    }
    private int FindUpperBound(long[] p,long target){
        int idx=-1;
        int l=0;
        int h=p.Length-1;

        while(l<=h){
            int mid=l+(h-l)/2;
            if(p[mid]>target){
                idx=mid;
                h=mid-1;
            }
            else{
                l=mid+1;
            }
        }
        return idx;
    }
}
