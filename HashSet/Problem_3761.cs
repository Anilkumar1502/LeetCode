public class Solution {
    public int MinMirrorPairDistance(int[] nums) {
        

        Dictionary<int,int> indexMap=new();
        int size=nums.Length;
        int min=size;

        for(int i=0;i<size;i++){

            int num=nums[i];
            if(indexMap.ContainsKey(num)){
                min=Math.Min(min,i-indexMap[num]);
            }
            int rnum=ReverseNumber(num);
            indexMap[rnum]=i;
        }
        return (min==size)?-1:min;
    }

    private int ReverseNumber(int num){
        int rev=0;
        while(num>0){
            rev=rev*10+num%10;
            num=num/10;
        }
        return rev;
    }
}
