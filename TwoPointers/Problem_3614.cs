public class Solution {
    public char ProcessStr(string s, long k) {
        
        long tc=0;
        int idx=-1;
        long temp=-1;
        for(int i=0;i<s.Length;i++){
            char c=s[i];
            if(char.IsLetter(c)){
                tc+=1;
            }
            else if(c=='*'){

                if(tc>0)
                tc-=1;
            }
            else if(c=='#'){
                tc+=tc;
            }

            if(tc<=k){
                idx=-1;
            }
            else if(idx==-1){
                idx=i;
                temp=tc;
            }
        }
        if(tc<k+1)
        return '.';

        
        for(int i=s.Length-1;i>=0;i--){
           // Console.WriteLine(tc);
            char c=s[i];
            if(char.IsLetter(c)){
                tc-=1;
                if(tc==k){
                    
                    return c;
                }
            }
            else if(c=='#'){
                tc=tc/2;
                if(tc<=k){
                    k=k-tc;
                }
            }
            else if(c=='%'){
                k=tc-k-1;
            }
            else{
                tc+=1;
            }
        }
        Console.WriteLine(k);
       
        return ' ';
    }
}
