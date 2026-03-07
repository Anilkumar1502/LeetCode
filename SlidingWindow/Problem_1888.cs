public class Solution {
    public int MinFlips(string s) {

        string fs=s+s;
        int n=s.Length;

        bool isOdd=true;
        int e=0;
        int o=0;
        int j=0;
        int min=int.MaxValue;
        for(int i=0;i<2*n;i++){

          bool even=(fs[i]=='0')?true:false;
            if(isOdd==even){
                e+=1;
            }
            else{
                o+=1;
            }
            isOdd=!isOdd;
            
            if(i>=n-1){
                min=Math.Min(min,Math.Min(e,o));   
                bool peven=(fs[j]=='0')?true:false;
                if(peven){
                   (e,o)=(o,e-1);
                }
                else{
                    (e,o)=(o-1,e);
                }
                j+=1;
                isOdd=!isOdd;
            }            
        }
        return min;
    }
}
