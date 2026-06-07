public class Solution {
    public int EarliestFinishTime(int[] ls, int[] ld, int[] ws, int[] wd) {
        
    
        int m1=GetMinimum(ls,ld,ws,wd);
        int m2=GetMinimum(ws,wd,ls,ld);

        return Math.Min(m1,m2);
    }

    private int GetMinimum(int[] r1,int[] d1,int[] r2,int[] d2){

        int f1=int.MaxValue;

        for(int i=0;i<r1.Length;i++){
            f1=Math.Min(f1,r1[i]+d1[i]);
        }
        int min=int.MaxValue;

        for(int i=0;i<r2.Length;i++){
            min=Math.Min(min,Math.Max(r2[i],f1)+d2[i]);
        }

        return min;
    }
}
