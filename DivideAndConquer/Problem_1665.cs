public class Solution {
    public int MinimumEffort(int[][] tasks) {
        
        int low=0;
        int high=0;
        int m=tasks.Length;
   
    
        int i=0;
        foreach(var task in tasks){
            low+=task[0];
            high+=task[1];
        
        }
     
        Array.Sort(tasks,(a,b)=>{
        if((a[1]-a[0])==b[1]-b[0])
        return b[1]-a[1];

        return (b[1]-b[0])-(a[1]-a[0]);
        }
        );


        int result=high;
        while(low<=high){
            int mid=low+(high-low)/2;
         //   Console.WriteLine($"{mid} {low} {high}");
            if(IsPositiveOrZero(mid,tasks)){
                result=Math.Min(result,mid);
                high=mid-1;
            }
            else{
                low=mid+1;
            }
        }
        return result;
    }

    private bool IsPositiveOrZero(int e,int[][] tasks){

       
        foreach(var task in tasks){
            if(e<task[1])
            {
                return false;
            }

            e-=task[0];
        }
        return true;
    }
}
