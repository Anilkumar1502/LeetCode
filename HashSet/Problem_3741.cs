public class Solution {
    public int MinimumDistance(int[] nums) {
       int min=int.MaxValue;

        Dictionary<int,List<int>> dict=new();

        int v=0;
        bool found=false;
        for(int i=0;i<nums.Length;i++){
            v=nums[i];
            if(dict.ContainsKey(v)){
                List<int> lst=dict[v];
                lst.Add(i);
                if(lst.Count>=3){
                    found=true;
                    int local=Calculate(lst);
                    if(local<min){
                        min=local;
                    }
                }
            }
            else{
                dict[v]=new List<int>(){i};
            }
        }
        if(!found)
        return -1;

        return min;
    }

    private int Calculate(List<int> lst){
        int cnt=lst.Count;
        int v1=lst[cnt-1];
        int v2=lst[cnt-2];
        int v3=lst[cnt-3];

        int sum=Math.Abs(v1-v2)+Math.Abs(v1-v3)+Math.Abs(v3-v2);
        return sum;
    }
}
