public class Solution {
    public long CountCommas(long n) {
       if(n<1000)
       return 0 ;

       long res=0;
       long temp=n;
       n=n/1000;
       long pow=1;
       int i=0;
       while(n>0){
        n=n/1000;
        i+=1;
        pow=pow*1000;
        if(n>0){           
            res=res+ 1L*i*(pow*1000-pow);
        }
        else{
            res= res + 1L*(temp-pow+1)*i;
        }
       }
       return res;  
    }
}
