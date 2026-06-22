public class Solution {
    public int RearrangeCharacters(string s, string target) {
        
        int[] t=new int[26];
        int[] src=new int[26];

        
        foreach(char c in target){
            int idx=c-'a';
            t[idx]+=1;
        }
        foreach(var c in s){
            int idx=c-'a';
            src[idx]+=1;
        }

        int min=101;
        for(int i=0;i<26;i++){
            if(t[i]==0)
            continue;

            src[i]=src[i]/t[i];
            min=Math.Min(min,src[i]);
        }
        return min;
    }
}
