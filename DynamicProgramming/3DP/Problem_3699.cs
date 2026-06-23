public class Solution {
    public int ZigZagArrays(int n, int l, int r) {
        
        long MOD=1000_000_007;
        r=r-l+1;
        l=1;

        long[][][] dp=new long[n][][];
        for(int i=0;i<n;i++){
            dp[i]=new long[2][];
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<2;j++){
                dp[i][j]=new long[r+1];
               // Array.Fill(dp[i][j],1);
            }
        }

        long[] prefix=new long[r+1];
        
        for(int i=1;i<=r;i++){
            dp[0][0][i]=1;
            dp[0][1][i]=1;
            prefix[i]=i;
        }

        int k=1;
        for(int i=1;i<n;i++){
            int nk=(k==1)?0:1;
            for(int j=1;j<=r;j++){
                dp[i][k][j]=0;             
                if(k==1){              
                      dp[i][k][j]=(prefix[r]-prefix[j])%MOD;
                }
                else{
                   dp[i][k][j]=prefix[j-1]%MOD;
                }  
            }
            for(int t=1;t<=r;t++){
                prefix[t]=prefix[t-1]+dp[i][k][t];
            } 
            k+=1;
            k%=2;
        }
        

        return (int)((prefix[r]*2)%MOD);

    }
}
