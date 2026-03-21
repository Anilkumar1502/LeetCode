public class Solution {
    public int[][] ReverseSubmatrix(int[][] grid, int x, int y, int k) {
        
        int low=x;
        int high=x+k-1;


        while(low<high){
            for(int j=y;j<y+k;j++){
               (grid[low][j],grid[high][j])=(grid[high][j],grid[low][j]);
            }
            low+=1;
            high-=1;
        }
        return grid;
    }
}
