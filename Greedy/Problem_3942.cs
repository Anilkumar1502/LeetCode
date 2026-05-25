public class Solution {
    public int MinOperations(int[] nums) {

        if(nums.Length==1)
        return 0;

        bool possible=true;
        int n=nums.Length;

        int check=nums[0];
        for(int i=1;i<n;i++){
            check+=1;
            int val=check%n;
            if(nums[i]!=val){
                possible=false;
                break;
            }
        }
        if(possible){
            int first=nums[0];
            int last=nums[n-1];
            return Math.Min((n-first)%n,2+(last+1)%n);
        }

        possible=true;
        check=nums[0];
        for(int i=1;i<n;i++){
            check=(check-1+n)%n;
            if(nums[i]!=check){
                possible=false;
                break;
            }
        }

        if(possible){
            int first=nums[0];
            int last=nums[n-1];

            return Math.Min(1+(first+1)%n,1+(n-last)%n);
        }

        if(!possible)
        return -1;

        

        // if(possible){
        //     int first=nums[0];
        //     if(first==n-1)
        //     return 1;

            
        // }


        return -1;
    }
}
