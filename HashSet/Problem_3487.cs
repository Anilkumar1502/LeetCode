public class Solution {
    public int MaxSum(int[] nums) {
        
        int max=int.MinValue;
        HashSet<int> hset=new();
        foreach(var num in nums){
            if(num>0){
                hset.Add(num);
            }
            max=Math.Max(max,num);
        }
        if(max<0)
        return max;

        int sum=0;
        foreach(var num in hset){
            sum+=num;
        }
        return sum;
   

  
    }
}
