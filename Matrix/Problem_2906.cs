public class Solution {
    public int[][] ConstructProductMatrix(int[][] grid) {
        
        int m=grid.Length;
        int n=grid[0].Length;

        int MOD=12345;

        int[][] p=new int[m][];
        for(int i=0;i<m;i++)
            p[i]=new int[n];

        int prod=1;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                p[i][j]=prod;
                prod=((grid[i][j]%MOD)*prod)%MOD;
            }
        }

        prod=1;
        for(int i=m-1;i>=0;i--){
            for(int j=n-1;j>=0;j--){
                p[i][j]=((p[i][j]%MOD)*prod)%MOD;
                prod=((grid[i][j]%MOD)*prod)%MOD;
            }
        }

        return p;
    }
}
