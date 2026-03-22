public class Solution {
    public bool FindRotation(int[][] mat, int[][] target) {
        

        for(int i=0;i<4;i++){
         bool isValid=Compare(mat,target);
         if(isValid)
         return true;
         TransposeAndRotate(mat);
        }

        return false;
    }

    private void TransposeAndRotate(int[][] mat){
        int n=mat.Length;
        for(int i=0;i<n;i++){
            for(int j=i;j<n;j++){
                (mat[i][j],mat[j][i])=(mat[j][i],mat[i][j]);
            }
        }

        for(int i=0;i<n/2;i++){
            for(int j=0;j<n;j++)
            (mat[i][j],mat[n-i-1][j])= (mat[n-i-1][j],mat[i][j]);
        }
    }
    private bool Compare(int[][] mat,int[][] target){
        int m=mat.Length;
        int n=mat[0].Length;

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(mat[i][j]!=target[i][j])
                return false;
            }
        }
        return true;
    }
}
