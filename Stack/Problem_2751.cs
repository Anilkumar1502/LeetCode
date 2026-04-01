public class Solution {
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions) {
        
        int m=positions.Length;
        int[][] p=new int[m][];
        for(int i=0;i<m;i++){
         p[i]=new int[2];
         p[i][0]=positions[i];
         p[i][1]=i;
        }

        Array.Sort(p,(a,b)=>a[0]-b[0]);

        Stack<int> stack=new();
        List<int> result=new List<int>();

        for(int i=0;i<m;i++){

           int idx=p[i][1];

           if(directions[idx]=='R'){
             stack.Push(idx);
             continue;
           }
           
           bool add=true;
           while(stack.Count>0)
           {
              if(healths[stack.Peek()]<=healths[idx]){
                int index=stack.Pop();
                if(healths[index]<healths[idx]){
                    healths[idx]-=1;
                }
                else{
                healths[idx]-=1;
                add=false;
                break;
                }
              }
              else{
                healths[stack.Peek()]-=1;
                add=false;
                break;
              }
           }
           
           if(!stack.Any()&&add)
           result.Add(idx);
        }

        while(stack.Any()){
            result.Add(stack.Pop());
        }
        result.Sort();
        IList<int> res=new List<int>();

        for(int i=0;i<result.Count;i++){
            res.Add(healths[result[i]]);
        }


        return res;
        
    }
}
