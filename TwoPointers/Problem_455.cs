public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        
        Array.Sort(g);
        Array.Sort(s);

        int gPtr=0;
        int sPtr=0;

        while(gPtr<g.Length&&sPtr<s.Length){
            if(g[gPtr]>s[sPtr]){
                sPtr+=1;
                continue;
            }

            gPtr+=1;
            sPtr+=1;
        }
        return gPtr;
    }
}
