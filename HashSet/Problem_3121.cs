public class Solution {
    public int NumberOfSpecialChars(string word) {
        

        int[] upper=new int[26];
        Array.Fill(upper,-1);
        int[] lower=new int[26];
        Array.Fill(lower,-1);
        for(int i=0; i<word.Length;i++){
            char c=word[i];
            if(c>='a'&&c<='z'){
                int val=c-'a';
                lower[val]=i;
            }
            else{
                int val=c-'A';
                if(upper[val]==-1){
                    upper[val]=i;
                }
            }
        }
        int special=0;
        for(int i=0;i<26;i++){
            if(upper[i]!=-1&&lower[i]!=-1&&lower[i]<upper[i])
             special+=1;
        }
        return special;
    }
}
