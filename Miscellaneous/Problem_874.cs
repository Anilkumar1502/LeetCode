public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        
        HashSet<(int x,int y)> obs=new ();

        for(int i=0;i<obstacles.Length;i++){
            obs.Add((obstacles[i][0],obstacles[i][1]));
        }

        bool px=false;
        bool nx=false;
        bool py=true;
        bool ny=false;
        
        int maxDistance=0;
        int currX=0; int currY=0;
        for(int i=0;i<commands.Length;i++){
           int cmd=commands[i];
           if(cmd==-1){
              if(py){
                py=!py;
                px=!px;
              }
              else if(px){
                px=!px;
                ny=!ny;
              }
              else if(ny){
                ny=!ny;
                nx=!nx;
              }
              else{
                nx=!nx;
                py=!py;
              }
              
           }
           else if(cmd==-2){
             if(py){
                py=!py;
                nx=!nx;
              }
              else if(nx){
                nx=!nx;
                ny=!ny;
              }
              else if(ny){
                ny=!ny;
                px=!px;
              }
              else{
                px=!px;
                py=!py;
              }
           }
           else{
            for(int j=0;j<cmd;j++){
                if(px){
                    if(obs.Contains((currX+1,currY)))
                    break;
                    currX+=1;
                }
                else if(nx){
                    if(obs.Contains((currX-1,currY)))
                    break;
                    currX-=1;
                }
                else if(py){
                    if(obs.Contains((currX,currY+1)))
                    break;
                    currY+=1;
                }
                else{
                    if(obs.Contains((currX,currY-1)))
                    break;
                    currY-=1;
                }
             }
           }

           maxDistance=Math.Max(maxDistance, currX*currX+currY*currY);
        }
        return maxDistance;
    }
}
