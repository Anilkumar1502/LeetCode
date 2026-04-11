public class Solution {
    public int MaxValue(int[] nums1, int[] nums0) {

        int m=nums1.Length;

        long MOD=1000_000_007L;
        int[][] nums=new int[m][];

        for(int i=0;i<m;i++){
            nums[i]=new int[2];
        }

        for(int i=0;i<nums1.Length;i++){
            nums[i][0]=nums1[i];
            nums[i][1]=nums0[i];
        }

        Array.Sort(nums,(a,b)=>{

            
            if(a[0]==b[0]){
                return a[1]-b[1];
            }
            if(a[1]!=0&&b[1]==0){
                return 1;
            }
            if(a[1]==0&&b[1]!=0){
                return -1;
            }
            return b[0]-a[0];
        });

       // StringBuilder builder=new();
// Dictionary<int,int> dict=new();
        long pow=1;
        long result=0;
        for(int i=m-1;i>=0;i--){
            int a=nums[i][0];
            int b=nums[i][1];

           // Console.WriteLine(a);

            while(b>0){
                pow=(pow*2)%MOD;
                b-=1;
            }
            while(a>0){
                result=(result+(pow*1)%MOD)%MOD;
                pow=(pow*2)%MOD;
                a-=1;
            }
        }
    //   Console.WriteLine(result);
        return (int)result;
    }
}
