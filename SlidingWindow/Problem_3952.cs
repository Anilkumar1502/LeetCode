public class Solution {
    public long MaxTotal(int[] nums, string s) {
        long res=0;

    
        int z=0;
        int n=s.Length;
        long temp=0;
        int min=100001;
        for(int i=0;i<n;i++){
            if(s[i]=='0'){
                
                if(min!=100001)
                {
                res+=temp;
                if(z>0)
                res-=min;
                }               
                temp=nums[i];
                min=nums[i];
                z=1;
                continue;
            }            
            temp+=nums[i];
            min=Math.Min(min,nums[i]);           
        }

        if(z==1)
        res+=(temp-min);
        else
        res+=temp;
        
        return res;
    }
}
