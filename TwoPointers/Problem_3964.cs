public class Solution {
    public int MinLights(int[] lights) {

        List<int[]> path=new();
        int n=lights.Length;
        for(int i=0;i<lights.Length;i++){
            if(lights[i]==0)
                continue;

            int v=lights[i];
            path.Add(new int[2]{Math.Max(0,i-v),Math.Min(n-1,v+i)});
        }

        if(!path.Any()){
            return GetBulb(n);
        }

        path.Sort((a,b)=>a[0]-b[0]);

        int min=0;
        int last=0;
        for(int i=0;i<path.Count;i++){
            int[] r=path[i];
            int s=r[0];
            int e=r[1];

            int diff=s-last;
            min+=GetBulb(diff);

            while(i<path.Count&&e>=path[i][0]){
                e=Math.Max(e,path[i][1]);
                i+=1;
            }
            i-=1;
            last=e+1;
        }

        min+=GetBulb(n-last);

        return min;
    }

    private int GetBulb(int n){
        if(n<0)
            return 0;
        if(n%3==0)
                return n/3;
            else 
                return 1+n/3;
    }
}
