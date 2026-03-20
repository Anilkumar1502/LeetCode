public class Solution {
    public int NumberOfSubmatrices(char[][] grid) {
        
        int m=grid.Length;
        int n=grid[0].Length;

        int[][] x=new int[m][];
        int[][] y=new int[m][];

        for(int i=0;i<m;i++)
        {
            x[i]=new int[n];
            y[i]=new int[n];
        }
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(grid[i][j]=='X'){
                  if(i==0)
                  x[i][j]=1;
                  else{
                  x[i][j]=1+x[i-1][j];
                  y[i][j]=y[i-1][j];
                  }
                }
                else if(grid[i][j]=='Y'){
                  if(i==0)
                  y[i][j]=1;
                  else{
                  y[i][j]=1+y[i-1][j];
                  x[i][j]=x[i-1][j];
                  }
                }
                else{
                    if(i!=0){    
                    x[i][j]=x[i-1][j];
                    y[i][j]=y[i-1][j];
                    }
                }
            }
        }

       
         
        int sumX=0;
        int sumY=0;
        int subMatrices=0;
        for(int i=0;i<m;i++){
            sumX=0;
            sumY=0;
            for(int j=0;j<n;j++){
               sumX+=x[i][j];
               sumY+=y[i][j];
               if(sumX!=0&&sumX==sumY)
               subMatrices+=1;
            }
           // Console.WriteLine(subMatrices);
        }
        return subMatrices;

    }
}
