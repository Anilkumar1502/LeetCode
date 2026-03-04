public class Solution {
    public int MaxScore(int[] cardPoints, int k) {
      
       int sum=0;
       int maxSum=0;
       int n=cardPoints.Length;
     
       for(int i=0;i<k;i++){
         sum+=cardPoints[i];
       }
       maxSum=sum;

       for(int i=k-1,j=0;i>=0;i--,j++){
         sum=sum+cardPoints[n-j-1]-cardPoints[i];
         maxSum=Math.Max(maxSum,sum);
       }
       return maxSum;
    }
}
