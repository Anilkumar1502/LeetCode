public class Solution {
    public int RemoveAlmostEqualCharacters(string word) {
        
        int n=word.Length;
        int[] arr=new int[n];

        for(int i=0;i<n;i++){
            arr[i]=word[i]-'a';
        }

        int min=0;
        for(int i=1;i<n;i++){
            if(Math.Abs(arr[i]-arr[i-1])<=1){
                arr[i]=-2;
                min+=1;
            }
        }
        return min;
    }
}
