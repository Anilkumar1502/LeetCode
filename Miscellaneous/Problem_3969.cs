public class Solution {
    public int CountValidSubarrays(int[] nums, int x) {

        int n=nums.Length;
        int cnt=0;
        for(int i=0;i<n;i++){
            long sum=0;
            for(int j=i;j<n;j++){
                sum+=nums[j];
                bool isValid=Validate(sum,1L*x);
                if(isValid){
               //     Console.WriteLine($"{i} {j}");
                    cnt+=1;
                }
            }
        }
        return cnt;
    }

    private bool Validate(long sum,long d){

        long single=sum/10;
        if(single==0&&sum==d)
            return true;

        
        long ld=sum%10;
        if(ld!=d)
            return false;

        while(sum>=10){
            sum=sum/10;
        }
        if(sum!=d)
            return false;

        return true;
        
    }
}
