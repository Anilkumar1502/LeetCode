public class Solution {
    public int MinMoves(int[] nums, int limit) {
        
        int[] possible=new int[2*limit+2];

      //  Array.Fill(possible,2);
        // for(int i=0;i<possible.Length;i++){
        //     possible[i]=i+2;
        // }

        int low=0;
        int high=nums.Length-1;

        while(low<high){
            int sum=nums[low]+nums[high];

            int min=Math.Min(nums[low],nums[high])+1;
            int max=Math.Max(nums[high],nums[low])+limit;
            possible[2]+=2;
          //  possible[2*limit+1]-=2;
            possible[sum]+=-1;
            possible[sum+1]+=1;
            possible[min]+=-1;
            possible[max+1]+=1;
            
            low+=1;
            high-=1;
        }

        int Min=int.MaxValue;
        int moves=0;
        for(int i=2;i<possible.Length-1;i++){
                moves+=possible[i];
                Min=Math.Min(Min,moves);
        }
        return Min;
    }
}
