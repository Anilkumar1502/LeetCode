public class Solution {
    public char[][] RotateTheBox(char[][] boxGrid) {
        
        int m=boxGrid.Length;
        int n=boxGrid[0].Length;

        char[][] r=new char[n][];

        for(int i=0;i<n;i++){
         r[i]=new char[m];
         Array.Fill(r[i],'.');
        }

        char[][] b=boxGrid;

        for(int i=0;i<m;i++){
            int cnt=0;
            int k=0;
            for(int j=0;j<n;j++){
                if(b[i][j]=='#'){
                    cnt+=1;
                }
                else if(b[i][j]=='*'){
                    r[j][m-i-1]='*';
                    k=j-1;
                    while(cnt>0&&k>=0){
                        r[k][m-i-1]='#';
                        cnt-=1;
                        k-=1;
                    }
                }
            }
            k=n-1;
            while(cnt>0&&k>=0){
                r[k][m-i-1]='#';
                cnt-=1;
                k-=1;
            }
        }
        return r;
    }
}
