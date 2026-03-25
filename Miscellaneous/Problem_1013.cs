public class Solution {
    public bool CanThreePartsEqualSum(int[] arr) {
        
        int sum=0;

        for(int i=0;i<arr.Length;i++)
        sum+=arr[i];


        if(sum%3!=0)
        return false;

        int subArraySum=sum/3;
         
        int currSum=0;
        int cnt=3;
        for(int i=0;i<arr.Length;i++){
           currSum+=arr[i];
           if(currSum==subArraySum)
           {
            cnt-=1;
            currSum=0;
           }
        }

        return cnt>0? false: true;
    }
}
