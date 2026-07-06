public class Solution {
    public int MinOperations(string s1, string s2) {


        int zf=0;
        int run=0;
        int o=0;
        int df=0;
        int n=s1.Length;
        if(n==1){
            if(s1[0]==s2[0])return 0;

            if(s1[0]=='0')return 1;

            return -1;
        }
        for(int i=0;i<n;i++){

            if(s1[i]=='0'&&s2[i]=='1')
                zf+=1;

            if(s1[i]=='1'&&s2[i]=='0'){
                run+=1;
                df+=1;
            }
            else{
                if(run%2==1){
                    o+=1;
                }
                run=0;
            }
        }

        if(run%2==1)
        o+=1;

        return zf+o+(o+df)/2;
    }
}
