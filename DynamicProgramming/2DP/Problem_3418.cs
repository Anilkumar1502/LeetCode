public class Solution {
    public int MaximumAmount(int[][] coins) {
        
        int m=coins.Length;
        int n=coins[0].Length;

        (long r0,long r1,long r2)[][] rob=new (long,long,long)[m][];

        for(int i=0;i<m;i++)
         rob[i]=new (long,long,long)[n];
        
        rob[0][0].r0=coins[0][0];
        if(coins[0][0]<0){
            rob[0][0].r1=0;
            rob[0][0].r2=int.MinValue;
        }
        for(int i=1;i<m;i++){
            int value=coins[i][0];
            if(coins[i][0]>=0){
                rob[i][0]=(rob[i-1][0].r0+value,rob[i-1][0].r1+value,rob[i-1][0].r2+value);
            }
            else{
                rob[i][0].r2=Math.Max(rob[i-1][0].r2+value,rob[i-1][0].r1);
                rob[i][0].r1=Math.Max(rob[i-1][0].r1+value,rob[i-1][0].r0);
                rob[i][0].r0=rob[i-1][0].r0+value;
            }
        }
        for(int i=1;i<n;i++){
            int value=coins[0][i];
            if(coins[0][i]>=0){
                rob[0][i]=(rob[0][i-1].r0+value,rob[0][i-1].r1+value,rob[0][i-1].r2+value);
            }
            else{
                rob[0][i].r2=Math.Max(rob[0][i-1].r2+value,rob[0][i-1].r1);
                rob[0][i].r1=Math.Max(rob[0][i-1].r1+value,rob[0][i-1].r0);
                rob[0][i].r0=rob[0][i-1].r0+value;
            }
        }


        for(int i=1;i<m;i++){
            for(int j=1;j<n;j++){
                int value=coins[i][j];
                    
                if(value>=0){                          
                     rob[i][j].r0=Math.Max(rob[i-1][j].r0,rob[i][j-1].r0)+value;
                     rob[i][j].r1=Math.Max(rob[i-1][j].r1,rob[i][j-1].r1)+value;
                     rob[i][j].r2=Math.Max(rob[i-1][j].r2,rob[i][j-1].r2)+value;
                }
                else{
                    rob[i][j].r2=Math.Max(Math.Max(rob[i][j-1].r2,rob[i-1][j].r2)+value,Math.Max(rob[i][j-1].r1,rob[i-1][j].r1));
                    rob[i][j].r1=Math.Max(Math.Max(rob[i][j-1].r1,rob[i-1][j].r1)+value,Math.Max(rob[i][j-1].r0,rob[i-1][j].r0));
                    rob[i][j].r0=Math.Max(rob[i][j-1].r0,rob[i-1][j].r0)+value;
                }
            }
        }

        // for(int i=1;i<m;i++){
        //     for(int j=0;j<n;j++){
        //       Console.Write($"{rob[i][j].r0} - {rob[i][j].r1} - {rob[i][j].r2} ");
        //     }
        //     Console.WriteLine();
        // }

        var tuple=rob[m-1][n-1];
        return (int)Math.Max(tuple.r0,Math.Max(tuple.r1,tuple.r2));
    }
}
