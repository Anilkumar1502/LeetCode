public class Solution {

    Dictionary<int,long> mods=new();
     long MOD=1000_000_007L;
    public int CountVisiblePeople(int n, int pos, int k) {

       

        if(k==0)
        return 2;

        int low=0;
        int high=n-1;

        int l=pos-low;
        int r=high-pos;


        int s=0;
        long res=0;
        CalculateMod(n);
        while(s<=k&&s<=l){
            long lposs=MODN(l,s);

            if(k-s>r){
            s+=1;
            continue;                
            }
            
            long rposs=MODN(r,k-s);

           // Console.WriteLine($"{lposs} {rposs}");
            long val=(1L*lposs*rposs)%MOD;
            res= res+val;
            res=res%MOD;

            s+=1;
        }

        return (int)((res*2)%MOD);
    }
    private void CalculateMod(int n){

        long prod=1;
        mods[0]=1L;
        for(int i=1;i<=n;i++){
            prod=(prod*i)%MOD;
            mods[i]=prod;
        }
    }

    private long MODN(int n,int r){

        if(n==0)
        return 1L;

        if(r==0)
        return 1L;

        long denom=(mods[r]*mods[n-r])%MOD;
        long num=(mods[n])%MOD;

        long inverse=1L;
        long b=denom;
        long pow=MOD-2;
        while(pow>0)
        {
            if((pow&1)==1){
                inverse=(inverse*b) %MOD;
            }
            b=(b*b)%MOD;
            pow=pow>>1;
        }
        return (num*inverse)%MOD;
    }
}
