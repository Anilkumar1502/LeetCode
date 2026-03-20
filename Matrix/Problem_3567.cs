public class Solution {
    public int[][] MinAbsDiff(int[][] grid, int k) {

        int m=grid.Length;
        int n=grid[0].Length;

        int[][] subMatrix=new int[m-k+1][];
        for(int i=0;i<m-k+1;i++)
         subMatrix[i]=new int[n-k+1];

        if(k==1)
        return subMatrix;

        List<int> subValues=new();
        for(int i=0;i<m-k+1;i++){
            for(int j=0;j<n-k+1;j++){

                subValues.Clear();
                for(int x=i;x<i+k;x++){
                    for(int y=j;y<j+k;y++) 
                    {
                        subValues.Add(grid[x][y]);
                        
                    }
                }
                int minValue=GetMinAbsoluteDiff(subValues);
                        subMatrix[i][j]=minValue;
            }
        }
        return subMatrix;
    }
    private int GetMinAbsoluteDiff(List<int> s){

        s.Sort();
        int min=int.MaxValue;
        for(int i=1;i<s.Count;i++){
            if(s[i]!=s[i-1])
            min=Math.Min(min,s[i]-s[i-1]);
            
        }
        min=(min==int.MaxValue)?0:min;
        return min;
        
    }
}
