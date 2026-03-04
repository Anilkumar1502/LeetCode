public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> map=new();
        int n=nums.Length;
        for(int i=0;i<n;i++){

            int find=target-nums[i];
            if(map.ContainsKey(find))
            return [i,map[find]];

            map[nums[i]]=i;
        }
        return [0,0];
    }
}
