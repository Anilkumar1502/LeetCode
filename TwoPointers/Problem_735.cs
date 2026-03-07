public class Solution {
    public int[] AsteroidCollision(int[] asteroids) {
        List<int> res=new();

        foreach(var num in asteroids){
            bool isAdd=true;

            while(res.Count>0&&res[^1]>0&&num<0){
               if(res[^1]==-num){
                res.RemoveAt(res.Count-1);
                isAdd=false;
                break;
               }
               else if(res[^1]<-num){
                res.RemoveAt(res.Count-1);
                continue;
               }
               isAdd=false;
               break;
            }
            if(isAdd)
            res.Add(num);
        }
        return res.ToArray();
    }
}
