public class Solution {
    public bool CanBeEqual(string s1, string s2) {
         int n=s1.Length;
        (int p1,int p2)[] parity=new (int,int)[26];

        for(int i=0;i<n;i++){
            int idx=s1[i]-'a';
            if(i%2==1)
            parity[idx].p1+=1;
            else
            parity[idx].p2+=1;
        }

        for(int i=0;i<n;i++){
            int idx=s2[i]-'a';
            var tuple=parity[idx];
            if(i%2==1)
            tuple.p1-=1;
            else
            tuple.p2-=1;

            parity[idx]=tuple;
            if(tuple.p1<0||tuple.p2<0)
            return false;
        }
        return true;

    }
}
