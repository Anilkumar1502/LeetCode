public class Solution {
    public int FirstMatchingIndex(string s) {

        int low=0;
        int high=s.Length-1;

        while(low<=high){
            if(s[low]==s[high])
            return low;

            low+=1;
            high-=1;
        }

        return -1;
    }
}
