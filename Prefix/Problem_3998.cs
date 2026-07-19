public class Solution {
    public bool[] TransformStr(string s, string[] strs) {

      
        int n=strs.Length;
        bool[] result=new bool[n];
        Array.Fill(result,true);

        int m=s.Length;
        int[] prefix=new int[m];

        prefix[0]=s[0]-'0';
        for(int i=1;i<m;i++){
            prefix[i]=prefix[i-1]+s[i]-'0';
        }

        int[] p=new int[m];
        p[m-1]=(s[m-1]=='0')?1:0;

        for(int i=m-2;i>=0;i--){
            p[i]=p[i+1]+((s[i]=='0')?1:0);
        }
    

        for(int i=0;i<n;i++){
            int o=0;
            int e=0;
            int q=0;
            for(int j=0;j<m;j++){
                if(strs[i][j]=='?'){
                    q+=1;
                }
                else if(strs[i][j]=='1'){
                    o+=1;
                }
                else{
                    e+=1;
                }
                if(o>prefix[j]){
                   // Console.WriteLine($"{prefix[i]} {o}");
                    result[i]=false;
                    break;
                }
            }
            if(prefix[m-1]>o+q){
                result[i]=false;
            }
            
        }

         for(int i=0;i<n;i++){
            int o=0;
            int e=0;
            int q=0;
            for(int j=m-1;j>=0;j--){
                if(strs[i][j]=='?'){
                    q+=1;
                }
                else if(strs[i][j]=='1'){
                    o+=1;
                }
                else{
                    e+=1;
                }
                if(e>p[j]){
                   // Console.WriteLine($"{prefix[i]} {o}");
                    result[i]=false;
                    break;
                }
            }
            if(p[m-1]>e+q){
                result[i]=false;
            }
            
        }
        return result;

        
    }
}
