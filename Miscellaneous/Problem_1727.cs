public class Solution {
    public int LargestSubmatrix(int[][] matrix) {

        int m=matrix.Length;
        int n=matrix[0].Length;

        int max=0;
        int tmax=0;
        int[] h=new int[n];

        for(int i=0;i<m;i++){
            tmax=0;
            for(int j=0;j<n;j++){
                if(matrix[i][j]==1){
                    h[j]+=1;
                    continue;
                }
                h[j]=0;
            }
            tmax=FindMaxSubMatrix(h);
            max=Math.Max(max,tmax);
        }
        return max;
    }
    private int FindMaxSubMatrix(int[] h){

        List<int> ht=new();
        for(int i=0;i<h.Length;i++){
            if(h[i]!=0){
                ht.Add(h[i]);
            }
        }
        ht.Sort();
        int max=0;
        int n=ht.Count;
        for(int i=0;i<n;i++){
            max=Math.Max(max,(n-i)*ht[i]);
        }
        return max;
    }
}
