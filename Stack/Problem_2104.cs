public class Solution {
    public long SubArrayRanges(int[] nums) {
        
        int n=nums.Length;
       

        long minSum=FindSubArrayMinSum(nums);
        long maxSum=FindSubArrayMaxSum(nums);

      //  Console.WriteLine(minSum);

        return maxSum-minSum;
    }

    private long FindSubArrayMinSum(int[] nums){
   
        Stack<int> stack=new();
        long sum=0;
        int n=nums.Length;
        for(int i=0;i<n;i++){
            while(stack.Count>0&&nums[stack.Peek()]>nums[i]){
                 int idx=stack.Pop();
                 int j=stack.Count==0?-1:stack.Peek();

                 sum+=1L*(idx-j)*(i-idx)*nums[idx];
               //  r[idx]=i-idx;
            }
            stack.Push(i);
        }
        while(stack.Count>0){
           int idx=stack.Pop();
           int j=stack.Count==0?-1:stack.Peek();
           sum+=1L*(idx-j)*(n-idx)*nums[idx];
          // r[idx]=n-idx;
        }

        return sum;
    }
     private long FindSubArrayMaxSum(int[] nums){
   
        Stack<int> stack=new();
        long sum=0;
        int n=nums.Length;
        for(int i=0;i<n;i++){
            while(stack.Count>0&&nums[stack.Peek()]<nums[i]){
                 int idx=stack.Pop();
                 int j=stack.Count==0?-1:stack.Peek();

                 sum+=1L*(idx-j)*(i-idx)*nums[idx];
            }
            stack.Push(i);
        }
        while(stack.Count>0){
           int idx=stack.Pop();
           int j=stack.Count==0?-1:stack.Peek();

           sum+=1L*(idx-j)*(n-idx)*nums[idx];
           
        }

        return sum;
    }
}
