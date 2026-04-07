public class Robot {

    
    bool px=true;
    bool nx=false;
    bool py=false;
    bool ny=false;
    int m;
    int n;
    int currX=0;
    int currY=0;
    int perimeter;
    public Robot(int width, int height) {
        m=width;
        n=height;
        perimeter=2*(m+n)-4;
    }
    
    public void Step(int num) {
   
         int val;
         num=num%perimeter;

         if(num==0){
            if(currX==0&&currY==0)
            {
                px=false;
                ny=true;
            }
         }
       //  Console.WriteLine(num);
        //  if(num==0&&px){
        //     px=false;
        //     ny=true;
        //  }
         while(num>0){
            
           if(px){
            val=TurnRight(num);
           }
           else if(nx){
            val=TurnLeft(num);
           }
           else if(ny){
            val=TurnDown(num);
           }
           else{
            val=TurnTop(num);
           }
           num-=val;
         }  

        //Console.WriteLine($"{currX} {currY} {num}"); 
    }

    private int TurnRight(int num){
       if(currX+num<m){
       currX+=num;
       return num;
       }
       
       int temp=currX;
       currX=m-1;
       py=true;
       px=false;
       return m-temp-1;

    }
    private int TurnTop(int num){
       if(currY+num<n){
       currY=currY+num;
       return num;
       }

       int temp=currY;
       currY=n-1;
       nx=true;
       py=false;

       return n-temp-1;
    }
    private int TurnDown(int num){
        if(currY-num>=0){
        currY=currY-num;
        return num;
        }

        int temp=currY;
        currY=0;
        px=true;
        ny=false;

        return temp;

    }
    private int TurnLeft(int num){
      if(currX-num>=0){
      currX-=num;
      return num;
      }

      int temp=currX;
      currX=0;
      nx=false;
      ny=true;

      return temp;
    }
    
    public int[] GetPos() {
        return [currX,currY];
    }
    
    public string GetDir() {
        if(px)
        return "East";
        else if(nx)
        return "West";
        else if(py)
        return "North";
        else
        return "South";
    }
}

/**
 * Your Robot object will be instantiated and called as such:
 * Robot obj = new Robot(width, height);
 * obj.Step(num);
 * int[] param_2 = obj.GetPos();
 * string param_3 = obj.GetDir();
 */
