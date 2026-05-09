public class Solution {
    public int MinJumps(int[] nums) {
        
        if(nums.Length==1)
        return 0;

        int max=-1;   
        
        Dictionary<int,List<int>> map=new();
     //   Dictionary<int,bool> visitMap=new();
        for(int i=0; i<nums.Length;i++){
            int num=nums[i];
            max=Math.Max(max,num);
            if(!map.ContainsKey(num))
             map[num]=new();

            map[num].Add(i);
         //   visitMap[num]=false;
        }

        HashSet<int> primes=CalculatePrimes(max+1,map);
       
        Queue<int> queue=new();

        int n=nums.Length;

        if(primes.Contains(nums[0])&&nums[n-1]%nums[0]==0)
        return 1;

        
        
        bool[] visit=new bool[n];
 
        queue.Enqueue(0);
        visit[0]=true;
        int level=0;
        while(queue.Count>0){

            int cnt=queue.Count;
            while(cnt>0){
            int idx=queue.Dequeue();          

            if(idx==n-1)
            return level;

            if(idx>0&&!visit[idx-1]){
                visit[idx-1]=true;
                queue.Enqueue(idx-1);
            }
            if(idx<n-1&&!visit[idx+1]){
                visit[idx+1]=true;
                queue.Enqueue(idx+1);
            }
            if(primes.Contains(nums[idx])){
                
                int v=nums[idx];
                for(int i=1;i*v<=max;i++){
                    int prod=i*v;
                    if(map.ContainsKey(prod)){
                        List<int> list=map[prod];
                        foreach(var index in list){
                            if(visit[index])
                            continue;

                            if(idx!=index){
                                visit[index]=true;
                                queue.Enqueue(index); 
                                //Console.WriteLine(level);                      
                            }  
                        }
                        map.Remove(prod);
                    }
                }         
            }
            cnt-=1;
            }
            
            level+=1;     
        }
        return -1;
    }

    private HashSet<int> CalculatePrimes(int n,Dictionary<int,List<int>> map){
        bool[] prime=new bool[n];
        Array.Fill(prime,true);
        HashSet<int> primes=new();
        for(int i=2;i<n;i++){
            if(!prime[i])
            continue;

            if(map.ContainsKey(i))
            primes.Add(i);

            for(int j=2;j*i<n;j++){
                prime[i*j]=false;
            }
        }

        
        return primes;
        
    }

}
