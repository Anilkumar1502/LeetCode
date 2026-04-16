public class Solution {
    public IList<int> SolveQueries(int[] nums, int[] queries) {
        

        Dictionary<int,List<int>> freq=new();

        int len=nums.Length;
        for(int i=0;i<nums.Length;i++){
            int num=nums[i];
            if(!freq.ContainsKey(num)){
                freq[num]=new();
            }
            freq[num].Add(i);
        }

        int q=queries.Length;
        int[] answer=new int[q];

        for(int i=0;i<q;i++){
            int idx=queries[i];
            int val=nums[idx];
            List<int> indexes=freq[val];
            int n=indexes.Count;

            if(indexes.Count==1){
                answer[i]=-1;
                continue;
            }
            // if(indexes.Count==2){
            //     if(indexes[0]==idx){
                    
            //     }
            //     else{

            //     }
            //     continue;
            // }
            int index=BinarySearch(idx,indexes);
           // Console.WriteLine(index);
            int idx1=indexes[(index+1)%n];
            int idx2=indexes[(index-1+n)%n];
            answer[i]=Math.Min(Math.Abs(idx-idx1),Math.Abs(idx-idx2));

            answer[i]=Math.Min(answer[i],Math.Abs(len-idx1+idx));
            answer[i]=Math.Min(answer[i],Math.Abs(len-idx+idx1));
            answer[i]=Math.Min(answer[i],Math.Abs(len-idx2+idx));
            answer[i]=Math.Min(answer[i],Math.Abs(len-idx+idx2));
        }

        return answer;
    }

    private int BinarySearch(int target,List<int> arr){

        int low=0;
        int high=arr.Count-1;

        while(low<=high){
            int mid=low+(high-low)/2;
            if(arr[mid]==target)
            return mid;
            else if(arr[mid]>target){
                high=mid-1;
            }
            else{
                low=mid+1;
            }
        }
        return -1;
    }
}
