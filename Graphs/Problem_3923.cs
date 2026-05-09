public class Solution {
    public int MinGenerations(int[][] points, int[] target) {

        if(points.Length==1){
           int[] point= points[0];
           if(point[0]==target[0]&&point[1]==target[1]&&point[2]==target[2])
            return 0;

           return -1;
        }

        bool[][][] visit=new bool[7][][];

        for(int i=0;i<7;i++){
            visit[i]=new bool[7][];
        }

        for(int i=0;i<7;i++){
            for(int j=0;j<7;j++){
                visit[i][j]=new bool[7];
            }
        }

        List<int[]> l=points.ToList();
        foreach(var point in l){
 
            if(Compare(point,target)){
                return 0;
            }
            visit[point[0]][point[1]][point[2]]=true;
        }

        int count=0;
        int level=1;
        while(l.Count!=count){
            
            count=l.Count;
            List<int[]> temp=new();
            temp.Add(l[l.Count-1]);
            for(int i=0;i<l.Count-1;i++){
                temp.Add(l[i]);
                for(int j=i+1;j<l.Count;j++){
                    int nx=(l[i][0]+l[j][0])/2;
                    int ny=(l[i][1]+l[j][1])/2;
                    int nz=(l[i][2]+l[j][2])/2;
                    if(visit[nx][ny][nz])
                        continue;
                    visit[nx][ny][nz]=true;
                    
                    if(Compare([nx,ny,nz],target)){
                    return level;
                    }

                    temp.Add([nx,ny,nz]);
                  //  Console.WriteLine($"{temp.Count}");
                    
                }
            }
            l=temp;
            level+=1;
        }
        return -1;
    }

    private bool Compare(int[] a,int[] b){
            int x=a[0];
            int y=a[1];
            int z=a[2];
            int tx=b[0];
            int ty=b[1];
            int tz=b[2];
            if(x==tx&&y==ty&&z==tz){
                return true;
            }
        return false;
    }
}
