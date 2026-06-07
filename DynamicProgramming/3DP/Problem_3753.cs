class Solution {
    public long totalWaviness(long num1, long num2) {
        return Calculate(num2)-Calculate(num1-1);
    }


    private long Calculate(long num){
        if(num<=100)
        return 0;

        String s=Long.toString(num);
        long[][][][][][] dp=new long[17][11][11][2][2][2];
        boolean[][][][][] visit=new boolean[17][11][11][2][2];

        return DFS(s,0,10,10,1,1,visit,dp)[1];
    }

    private long[] DFS(String s,int idx,int l2,int l1,int ub,int lb,boolean[][][][][] visit,long[][][][][][] dp){
        if(idx==s.length())
        return new long[]{1,0};

        if(visit[idx][l2][l1][ub][lb]){
            return dp[idx][l2][l1][ub][lb];
        }

        visit[idx][l2][l1][ub][lb]=true;

        long cnt=0;
        long wave=0;
        int limit=ub==1?s.charAt(idx)-'0':9;

        for(int d=0;d<=limit;d++){
            int nub=(ub==1&&d==limit)?1:0;
            int nlb=(lb==1&&d==0)?1:0;

            int nl1=(nlb==1)?10:d;
            int nl2=(nlb==1)?10:(lb==1?10:l1);

            boolean wavy=false;

            if(l1!=10&&l2!=10){
                if((l1>d&&l1>l2)||(l1<d)&&(l1<l2))
                wavy=true;
            }

            long[] res=DFS(s,idx+1,nl2,nl1,nub,nlb,visit,dp);

            cnt+=res[0];
            wave+=res[1]+(wavy?res[0]:0);
        }

        dp[idx][l2][l1][ub][lb][0]=cnt;
        dp[idx][l2][l1][ub][lb][1]=wave;

        return dp[idx][l2][l1][ub][lb];
    }
}
