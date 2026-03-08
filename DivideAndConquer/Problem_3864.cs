public class Solution {
    public long MinCost(string s, int encCost, int flatCost) {
        
        int n=s.Length;
        int[] prefix=new int[n+1];

        int o=0;
        for(int i=1;i<=n;i++){
            o+=s[i-1]-'0';
            prefix[i]=o;
        }

        
        return Solve(prefix,1,n,encCost,flatCost);
        
    }

    private long Solve(int[] prefix,int l,int h,int e,int f){

       
        int ones=prefix[h]-prefix[l-1];
        int sLength=h-l+1;
        long cost=0; 
        if(ones==0)
        cost=f;
        else
        cost=1L*ones*sLength*e;

        if(sLength%2==0){
          int mid=l+(h-l)/2;
          cost=Math.Min(cost,Solve(prefix,l,mid,e,f)+Solve(prefix,mid+1,h,e,f));
        }

        return cost;
    }
}
