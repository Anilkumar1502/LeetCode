public class Solution {
    public int GetLength(int[] nums) {


        Dictionary<int,int> f=new();

       // HashSet<int> diff=new();

        int max=1;
        int n=nums.Length;
        for(int i=0;i<n;i++){

            int l=0;
            f.Clear();
            Dictionary<int,int> fq=new();
            int count=0;
            for(int j=i;j<n;j++){
                int val=nums[j];
                if(!f.ContainsKey(val)){
                    f[val]=0;
                }
                f[val]+=1;

                int v=f[val];

                if(fq.ContainsKey(v-1)){
                    fq[v-1]-=1;
                    if(fq[v-1]==0){
                        fq.Remove(v-1);
                    }
                }
                if(!fq.ContainsKey(v)){
                    fq[v]=0;
                }
                fq[v]+=1;

                if(fq.Count>2)
                continue;

                if(fq.Count==1){
                    if(f.Count==1)
                    max=Math.Max(max,j-i+1);
                }
                else if(fq.Count==2){
                   var keys= fq.Keys.ToList();
                   (int v1,int v2)=(keys[0],keys[1]);
                   if(v1>v2){
                     (v1,v2)=(v2,v1);
                   }

                    if(v2==v1*2){
                        max=Math.Max(max,j-i+1);
                    }
                }
            }
        }
        return max;
    }
}
