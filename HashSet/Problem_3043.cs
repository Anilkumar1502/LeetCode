public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        

        HashSet<int> prefixes=new();

        foreach(var val in arr1){

            int temp=val;
            while(temp>0){
                if(prefixes.Contains(temp))
                break;
                
                prefixes.Add(temp);
                temp/=10;
            }
        }

        int max=0;

        foreach(var val in arr2){
           int temp=val;
           while(temp>0){
             if(prefixes.Contains(temp)){
                max=Math.Max(max,temp);
             }
             temp/=10;
           }
        }

        int size=0;
        while(max>0){
            max/=10;
            size+=1;
        }
        return size;
    }
}
