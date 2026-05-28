public class Solution {
    public int[] StringIndices(string[] wordsContainer, string[] wordsQuery) {
        
        int n=wordsQuery.Length;

        int[] res=new int[n];
        Trie[] root=new Trie[26];
        int wLen=int.MaxValue;
        int minLenIdx=-1;
        for(int i=0;i<wordsContainer.Length;i++){
           
           string word=wordsContainer[i];
           int len=word.Length;
           Trie[] temp=root;
           if(wLen>len){
            wLen=len;
            minLenIdx=i;
           }
           for(int j=len-1;j>=0;j--){
                int idx=word[j]-'a';
                if(temp[idx] is null){
                    temp[idx]=new Trie();
                    temp[idx].idx=i;
                    temp[idx].len=len;

                    temp=temp[idx].child;
                }
                else{
                    if(temp[idx].len>len){
                        temp[idx].len=len;
                        temp[idx].idx=i;
                    }
                    temp=temp[idx].child;
                }
           }
        }
        
        for(int i=0;i<wordsQuery.Length;i++){
            string word=wordsQuery[i];
            int len=word.Length;
            Trie[] temp=root;
            int r=minLenIdx;
            for(int j=len-1;j>=0;j--){
                    int idx=word[j]-'a';
                    if(temp[idx] is null){
                        break;
                    }
                    
                    r=temp[idx].idx;
                    temp=temp[idx].child;
            }
            res[i]=r;
        }

        return res;



    }
}

public class Trie{

    public Trie[] child;

    public int idx=-1;

    public int len=100001;

    public Trie(){
        child=new Trie[26];
    }
}
