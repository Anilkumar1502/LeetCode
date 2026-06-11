public class Solution {
    public int MaxSubstrings(string word) {
        
        int[] abts=new int[26];

        Array.Fill(abts,-1);

        int cnt=0;
        for(int i=0;i<word.Length;i++){
            int idx=word[i]-'a';
            if(abts[idx]==-1){
            abts[idx]=i;
            continue;
            }

            if((i-abts[idx]+1)>3){
               // Console.WriteLine(i);
                cnt+=1;
                Array.Fill(abts,-1);
            }

        }
        return cnt;
    }
}
