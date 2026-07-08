public class Solution {
    public int[] SumAndMultiply(string s, int[][] queries) {
        
        int n=s.Length;
        long MOD=1000_000_007L;
        int[] l=new int[n];
        int[] r=new int[n];

        int lt=0;
        int rt=-1;
        StringBuilder sb=new();
        for(int i=0;i<s.Length;i++){
            if(s[i]=='0')
            {
                l[i]=lt;
                r[i]=rt;
            }
            else{
            rt+=1;
            r[i]=rt;
            l[i]=lt;
            lt+=1;
            sb.Append(s[i]);
            }
        }
        string zs=sb.ToString();

        int ns=zs.Length;

        int[] prefix=new int[ns+1];
        long[] numPrefix=new long[ns+1];
        long[] dnmPrefix=new long[ns+1];

        long div=1;
        for(int i=ns-1;i>=0;i--){
            int val=zs[i]-'0';
            numPrefix[i]=((div*val)%MOD+numPrefix[i+1])%MOD;
            div*=10;
            div%=MOD;
        }

        long inv=700000005;
        dnmPrefix[0]=1;
        for(int i=1;i<=ns;i++){
            dnmPrefix[i]=(dnmPrefix[i-1] * inv) % MOD;
            prefix[i]=prefix[i-1]+zs[i-1]-'0';
        }

        int[] res=new int[queries.Length];
        for(int i=0;i<queries.Length;i++){
            int[] q=queries[i];
            if(r[q[1]]==-1||l[q[0]]>=zs.Length){
                continue;
            }
            int x=l[q[0]];
            int y=r[q[1]];

            int d=ns-y-1;
            long dnm=dnmPrefix[d];
            int val=prefix[y+1]-prefix[x];
            res[i]=(int)(((((numPrefix[x]+MOD-numPrefix[y+1])%MOD)*val)%MOD*dnm)%MOD);
        }



        return res;
    }
}
