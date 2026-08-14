public class Solution {
    public int[] ValidSequence(string word1, string word2) {
        
        int n=word1.Length;
        int m=word2.Length;

        int[] last=new int[m];
        Array.Fill(last,-1);

        int i=n-1;
        int j=m-1;
        while(j>=0&&i>=0){
            if(word1[i]==word2[j]){
                last[j]=i;
                j-=1;
            }
            i-=1;
        }

        bool canSkip=true;
        int[] res=new int[m];
        int k=0;
        i=0;
        j=0;

        while(i<n&&j<m){
            if(word1[i]==word2[j]){
                res[k++]=i;
                j+=1;
            }
            else if(canSkip&&(j==m-1||last[j+1]>i)){
                res[k++]=i;
                j+=1;
                canSkip=false;
            }
            i+=1;
        }

        if(j==m)
        return res;

        return new int[0];
    }
}
