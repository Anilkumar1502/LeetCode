public class Solution {
    public int CountLocalMaximums(int[][] matrix) {


        int max=-1;
        int m=matrix.Length;
        int n=matrix[0].Length;

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                max=Math.Max(max,matrix[i][j]);
            }
        }
        
        int[][][] prefix=new int[max+1][][];

        for(int i=0;i<max+1;i++){
            prefix[i]=new int[m+1][];
        }
        for(int i=0;i<max+1;i++){
            for(int j=0;j<m+1;j++){
                prefix[i][j]=new int[n+1];
            }
        }

       for(int i=0;i<=max;i++){
           for(int j=1;j<=m;j++){
               for(int k=1;k<=n;k++){
                   int f=(matrix[j-1][k-1]>i)?1:0;
                   prefix[i][j][k]=f
                   +prefix[i][j-1][k]
                   +prefix[i][j][k-1]
                   -prefix[i][j-1][k-1];
               }
           }
       }

        int cnt=0;


        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){

                if(matrix[i][j]==0)
                 continue;

                int v=matrix[i][j];

                int r1=(i-v>=0)?(i-v):0;
                int r2=(i+v<m)?(i+v):m-1;
                int c1=(j-v>=0)?(j-v):0;
                int c2=(j+v<n)?(j+v):n-1;

                int value=IsLocalMaximum(v,r1,r2,c1,c2,prefix);

                if(i-v>=0&&j-v>=0){
                    value-=(matrix[r1][c1]>v)?1:0;
                }
                if(i-v>=0&&j+v<n){
                    value-=(matrix[r1][c2]>v)?1:0;
                }
                if(i+v<m&&j-v>=0){
                    value-=(matrix[r2][c1]>v)?1:0;
                }
                if(i+v<m&&j+v<n){
                    value-=(matrix[r2][c2]>v)?1:0;
                }
                bool vd=(value>0)?false:true;
                if(vd){
                cnt+=1;
                }
            }
        }

        return cnt;
    }

    private int IsLocalMaximum(int v,int r1,int r2,int c1,int c2,int[][][] p){

        //Console.WriteLine($"{p[v][r2+1][c2+1]}-{p[v][r1+1][c1+1]}");
        return p[v][r2+1][c2+1]-p[v][r1][c2+1]-p[v][r2+1][c1]+p[v][r1][c1];
       
    }
}
