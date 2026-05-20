public class Solution {
    public int MinJumps(int[] arr) {
        
        if(arr.Length==1)
        return 0;

        int n=arr.Length;
        Dictionary<int,List<int>> indmap=new();
        bool[] visit=new bool[n];
        for(int i=0;i<n;i++){
            int key=arr[i];
            if(!indmap.ContainsKey(key)){
                indmap[key]=new();
            }
            indmap[key].Add(i);
        }

        Queue<int> queue=new();

        queue.Enqueue(0);
        int level=0;
        while(queue.Count>0){
            int cnt=queue.Count;

            while(cnt>0){
                int index=queue.Dequeue();
                int key=arr[index];
                if(index==n-1)
                return level;

                visit[index]=true;

                if(index>0&&!visit[index-1]){
                    queue.Enqueue(index-1);
                }
                if(index<n-1&&!visit[index+1]){
                    queue.Enqueue(index+1);
                }

                if(indmap.ContainsKey(key)){

                    List<int> indices=indmap[key];
                    foreach(var i in indices){
                        queue.Enqueue(i);
                    }
                    indmap.Remove(key);
                }
                cnt-=1;
            }
            level+=1;
        }
        return -1;
    }
}
