public class Solution {
    public int MinCost(int[] nums1, int[] nums2) {

        Dictionary<int,int> f1=new();
        Dictionary<int,int> f2=new();

        int n=nums1.Length;
        for(int i=0;i<n;i++){
            if(!f1.ContainsKey(nums1[i]))
             f1[nums1[i]]=0;

            if(!f2.ContainsKey(nums2[i]))
              f2[nums2[i]]=0;

            f1[nums1[i]]+=1;
            f2[nums2[i]]+=1;
        }

        int c1=0;
       // int c4=0;
        foreach(var kv in f1){
            int key=kv.Key;
            int val=kv.Value;
            if(f2.ContainsKey(key)){
                int val2=f2[key];
                if(val==val2)
                continue;
                if((val+val2)%2==1)
                return -1; 
                
                if(val>val2)
                c1+=(val-val2)/2;
            }
            else{
                if(val%2==1)
                return -1;
                c1=c1+(val/2);
            }
        }
        int c2=0;
     
        foreach(var kv in f2){
            int key=kv.Key;
            int val=kv.Value;
            if(!f1.ContainsKey(key)){
                if(val%2==1)
                return -1;              
            }
           
        }

        return c1;
    }
}
