public class Solution {
    public IList<string> ValidStrings(int n) {
        
        IList<string> result=new List<string>();

        Queue<string> queue=new();

        queue.Enqueue("0");
        queue.Enqueue("1");

        while(queue.Count>0&&n>1){
            int cnt=queue.Count;
            while(cnt>0){
                string value=queue.Dequeue();
                string v1=$"{value}1";
                queue.Enqueue(v1);
                if(value[^1]=='1'){                   
                   string v2=$"{value}0";
                   queue.Enqueue(v2);
                }
               cnt-=1;
            }
            n-=1;
        }
        while(queue.Count>0){
            result.Add(queue.Dequeue());
        }
        return result;

    }
}
