public class Solution {
    public int MaxArea(int[][] mat) {

        int m=mat.Length;
        int n=mat[0].Length;

        int max=Math.Max(Math.Min(((m-1)/2 )+1,n),Math.Min(m,((n-1)/2)+1));

        int o=0;
        for(int i=0;i<m;i++){
            for(int j=0;j<n;j++){
                if(mat[i][j]==1){
                    o+=1;
                }
            }
        }
        if(o==0||o==1)
        return 0;

        for(int i=0;i<m;i++){
            for(int j=1;j<n;j++){             
                mat[i][j]+=mat[i][j-1];
            }
        }
        
        for(int i=1;i<m;i++){
            for(int j=0;j<n;j++){
                mat[i][j]+=mat[i-1][j];
            }
        }

        // for(int i=0;i<m;i++){
        //     for(int j=0;j<n;j++){
        //         Console.Write($"{mat[i][j]} ");
        //     }
        //     Console.WriteLine();
        // }

      

        int minX=501;
        int minY=501;
        int maxX=-1;
        int maxY=-1;
        for(int k=max;k>0;k--){
            int cnt=0;
            for(int i=k-1;i<m;i++){
                for(int j=k-1;j<n;j++){
                    int val;
                    int a;
                    int b;
                    int c;
                    a=(i==k-1)?0:mat[i-k][j];
                    b=(j==k-1)?0:mat[i][j-k];
                    c=(i!=k-1&&j!=k-1)?mat[i-k][j-k]:0;

                    val=mat[i][j]-a-b+c;
                    if(k*k==val){                      
                        minX=Math.Min(i,minX);
                        minY=Math.Min(j,minY);
                        maxX=Math.Max(i,maxX);
                        maxY=Math.Max(j,maxY);

                        int v1=maxX-minX;
                        int v2=maxY-minY;
                        if(v1>=k||v2>=k)
                        return val;
                    }
                }
            }


            
         
        }

        return 1;

        
    }
}
