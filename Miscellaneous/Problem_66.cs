public class Solution {
    public int[] PlusOne(int[] digits) {
        
        int n=digits.Length;
        for(int i=n-1;i>=0;i--){

            digits[i]+=1;
            if(digits[i]<10)
            return digits;

            digits[i]=0;
        }
        int[] added=new int[n+1];
        added[0]=1;
        return added;
    }
}
