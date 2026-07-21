public class Solution {
    public int MaxActiveSectionsAfterTrade(string s) {
        
        int n=s.Length;
        int l=0;
        int r=0;
        int right=0;
        int left=-1;
        int con=0;
        int max=0;
        int ones=0;
        for(int i=0;i<s.Length;i++){
            if(s[i]=='1'){
              

                if(l!=0&&r!=0){
                int val=r+l;
                if(val>=max){
                    right=i;
                    left=right-val-con-1;
                    max=val;
                    ones=con;
                }
                l=r;
                r=0;
                con=0;
                }
                if(l==0){
                    l=r;
                    r=0;
                    con=0;
                }
                con+=1;

                
            }
            else{
                if(con==0){
                    l+=1;
                }
                else{
                    r+=1;
                }
            }
        }

        if(l==0)
        return n-r;

        
        
        if(l!=0&&r!=0){
                int val=r+l;
                if(val>=max){
                    right=n;
                    left=right-val-con-1;
                    max=val;
                    ones=con;
                }
        }
        
        while(left>=0){
            if(s[left]=='1'){
                max+=1;
            }
            left-=1;
        }
        while(right<n){
            if(s[right]=='1'){
                max+=1;
            }
            right+=1;
        }
       

        return max+ones;
    }
}
