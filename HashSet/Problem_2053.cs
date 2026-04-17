public class Solution {
    public string KthDistinct(string[] arr, int k) {
        
        Dictionary<string,int> freqMap=new();
        foreach(var str in arr){
            if(!freqMap.ContainsKey(str)){
                freqMap[str]=0;
            }
            freqMap[str]+=1;
        }

        foreach(var str in arr){
            if(freqMap[str]==1)
            k-=1;
            if(k==0)
            return str;
        }
        return string.Empty;
    }
}
