public class Solution {
    public bool CanPartitionGrid(int[][] grid) {
        
        long sum=0;
        int m=grid.Length;
        int n=grid[0].Length;

        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++)
             sum+=grid[i][j];
        }

        if(sum%2!=0)
        return false;
        
        long partitionSum=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
               partitionSum+=grid[i][j];                    
            }
            if(partitionSum==(sum-partitionSum))
            return true;

            if(partitionSum*2>sum)
            break;
        }
        partitionSum=0;
        for(int i=0;i<n;i++){
            for(int j=0;j<m;j++){
               partitionSum+=grid[j][i];                    
            }
            if(partitionSum==(sum-partitionSum))
            return true;

            if(partitionSum*2>sum)
            break;
        }
        return false;
    }
}
