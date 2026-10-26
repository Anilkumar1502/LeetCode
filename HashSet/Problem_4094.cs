public class Solution {
    public int CountStaircase(int[] nums) {
        
        int n=nums.Length;
        int total=0;
        for(int i=0;i<n;i++){
            int k=0;
            Dictionary<int,int[]> d=new();
            for(int j=i;j<n;j++){
                int key=nums[j];
                if(d.ContainsKey(key)){
                    d[key][1]+=1;
                }
                else{
                    d[key]=[d.Count+1,1];
                }

                if(d[key][1]>d[key][0])
                break;

                if(d[key][0]==d[key][1]){
                    k+=1;
                }

                if(k==d.Count){
                    total+=1;
                }
                
            }
        }
        return total;
    }
}
