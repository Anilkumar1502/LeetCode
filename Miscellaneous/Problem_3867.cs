public class Solution {
    public long GcdSum(int[] nums) {

        long sum=0;
        int n=nums.Length;
        int[] prefix=new int[n];

        int max=int.MinValue;
        for(int i=0;i<n;i++){
            max=Math.Max(max,nums[i]);
            prefix[i]=GCD(max,nums[i]);
        }

        Array.Sort(prefix);

        int low=0;
        int high=n-1;

        while(low<high){
            sum+=GCD(prefix[low],prefix[high]);
            low+=1;
            high-=1;
        }
        return sum;
    }
    private int GCD(int a,int b){

        if(a<b){
            (a,b)=(b,a);
        }
        while(b!=0){
            int temp=b;
            b=a%b;
            a=temp;
        }
        return a;
    }
}©leetcode
