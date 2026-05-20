public class Solution {
    public int[] FindThePrefixCommonArray(int[] A, int[] B) {
        
        int n=A.Length;
     
        int[] res=new int[n];

        int[] a=new int[n+1];
        int[] b=new int[n+1];

        int cnt=0;
        for(int i=0;i<n;i++){
           
           if(A[i]==B[i]){
            cnt+=1;
           }
           else{
            a[A[i]]=1;
            b[B[i]]=1;

            if(a[B[i]]==1){
                cnt+=1;
            }
            if(b[A[i]]==1){
                cnt+=1;
            }
           }

           res[i]=cnt;
        }
        return res;
    }
}
