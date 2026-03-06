public class Solution {
    public bool CheckOnesSegment(string s) {
        
        int j=0;
        int cnt=0;
        for(int i=1;i<s.Length;i++){
           if(s[i]!=s[j]){
            cnt+=1;
            j=i;
            if(cnt>1)
            return false;
           }
        }
        return true;
    }
}
