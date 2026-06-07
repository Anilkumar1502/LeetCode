public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        
        int n=s.Length;
        bool[] dp=new bool[n];
        dp[0]=true;

        int r=0;
        for(int i=1;i<n;i++){
            if(i-minJump>=0&&dp[i-minJump]){
                r+=1;
            }
            if(i-maxJump-1>=0&&dp[i-maxJump-1]){
                r-=1;
            }
            if(s[i]=='0'&&r>0){
                dp[i]=true;
            }
        }
        return dp[n-1];
    }
}
