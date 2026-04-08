public class Solution {
    public int MirrorFrequency(string s) {
        
        int[] alphabet=new int[26];
        int[] digit=new int[10];

        for(int i=0;i<s.Length;i++){
            if(char.IsLetter(s[i])){
                alphabet[s[i]-'a']+=1;
                continue;
            }
            digit[s[i]-'0']+=1;
        }

        int absDiff=0;
        int low=0;
        int high=25;
        while(low<high){
            absDiff+=Math.Abs(alphabet[low]-alphabet[high]);
            low+=1;
            high-=1;
        }
        low=0;
        high=9;
        while(low<high){
            absDiff+=Math.Abs(digit[low]-digit[high]);
            low+=1;
            high-=1;
        }

        return absDiff;
    }
}
