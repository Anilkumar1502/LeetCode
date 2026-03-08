public class Solution {
    public string FindDifferentBinaryString(string[] nums) {
        
        int n=nums.Length;
        char[] res=new char[n];
        for(int i=0;i<n;i++){
            if(nums[i][i]=='1'){
                res[i]='0';
                continue;
            }
            res[i]='1';
        }

        return new string(res);
    }
}
