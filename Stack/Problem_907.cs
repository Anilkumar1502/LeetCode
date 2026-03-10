public class Solution {
    public int SumSubarrayMins(int[] arr) {
        
        long MOD=1000000007;
        int n=arr.Length;
        
        Stack<int> iStack=new();
        long sum=0;
        for(int i=0;i<n;i++){

            while(iStack.Count>0 && arr[iStack.Peek()]>arr[i]){
                int idx=iStack.Pop();
                int pidx=iStack.Count>0?iStack.Peek():-1;
                sum+=1L*(i-idx)*(idx-pidx)*arr[idx];
            }
            iStack.Push(i);
        }

        while(iStack.Count>0){
            int idx=iStack.Pop();
            int pidx=iStack.Count>0?iStack.Peek():-1;
            sum+=1L*(n-idx)*(idx-pidx)*arr[idx];
        }

        return (int)(sum%MOD);
       
    }
}
