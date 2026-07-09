public class Solution {
    public bool[] PathExistenceQueries(int n, int[] nums, int maxDiff, int[][] queries) {
        
        int[] components=new int[n];
        int qn=queries.Length;
        int j=0;
        components[0]=j;
        for(int i=1;i<n;i++){
            if(nums[i]-nums[i-1]<=maxDiff){
                components[i]=j;
                continue;
            }
            j+=1;
            components[i]=j;
        }

        bool[] status=new bool[qn];

        for(int i=0;i<qn;i++){
            int[] q=queries[i];

            if(components[q[0]]==components[q[1]]){
                status[i]=true;
            }
        }

        return status;
    }
}
