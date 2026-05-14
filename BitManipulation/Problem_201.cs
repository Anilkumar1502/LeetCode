public class Solution {
    public int RangeBitwiseAnd(int left, int right) {
        
       
        int[] l=new int[32];
        int[] r=new int[32];
        int bit=31;
        while(left>0||right>0){
           // Console.WriteLine(bit);
            l[bit]=left%2;
            r[bit]=right%2;

            left=left>>1;
            right=right>>1;
            bit-=1;
        }

        int sum=0;
        for(int i=0;i<32;i++){
            if(l[i]==0&&r[i]==1)
            return sum;

            if(l[i]==1&&r[i]==1)
             sum+= (int)Math.Pow(2,31-i);
        }
        return sum;
    }
}
