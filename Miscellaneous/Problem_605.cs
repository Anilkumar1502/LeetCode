public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        
        int size=flowerbed.Length;

        if(flowerbed.Length==1&&flowerbed[0]==0)
        return true;
        // if(n>size/2)
        // return false;

        for(int i=0;i<size;i++){
            if(flowerbed[i]==1)
            continue;

            if(i==0){
                if(flowerbed[i+1]==0){
                    flowerbed[i]=1;
                    n-=1;
                }
            }
            else if(i==size-1){
                if(flowerbed[i-1]==0){
                    flowerbed[i]=1;
                    n-=1;
                }
            }
            else{
                if(flowerbed[i-1]==0&&flowerbed[i+1]==0){
                    flowerbed[i]=1;
                    n-=1;
                }
            }
        }
      //  Console
        return n<=0?true:false;
    }
}
