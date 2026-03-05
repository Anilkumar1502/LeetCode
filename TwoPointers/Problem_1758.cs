public class Solution {
    public int MinOperations(string s) {

        int eops=0;
        int oops=0;

        bool fOdd=true;
        for(int i=0;i<s.Length;i++)
        {
            bool isEven=s[i]=='0'?true:false;
            if(fOdd==isEven)
            eops+=1;
            else
            oops+=1;
            fOdd=!fOdd;
        }
        return Math.Min(oops,eops);
    }
}
