public class Solution {
    public int CountMagicalPairs(string s) {

        int n=s.Length;
        int[][] f=new int[n][];
        int trip=0;

        for(int i=0;i<n;i++){

            int low=i;
            int high=i+1;
            HashSet<int> s1=new();
            HashSet<int> s2=new();
            while(low>=0&&high<n){
                int idx1=s[low]-'a';
                int idx2=s[high]-'a';
                s1.Add(idx1);
                s2.Add(idx2);
                if(s1.Count==s2.Count){
                    int gap1=0;
                    int gap2=0;
                    while(s1.Count==s2.Count&&low>=0){

                        if(!s1.Contains(s[low]-'a'))
                        break;

                        low-=1;
                        gap1+=1;
                    }

                    while(s1.Count==s2.Count&&high<n){
                       
                        if(!s2.Contains(s[high]-'a'))
                        break;
                        high+=1;
                        gap2+=1;
                    }
                    trip+=gap1*gap2;
                }
                else if(s1.Count>s2.Count){
                    high+=1;
                }
                else{
                    low-=1;
                }
            }
        }
        return trip;
    }
}
