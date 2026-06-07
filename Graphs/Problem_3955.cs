public class Solution {
    public IList<string> GenerateValidStrings(int n, int k) {

        IList<string> valid=new List<string>();

        Queue<List<char>> queue=new();

        queue.Enqueue(new List<char>(){'0'});
        queue.Enqueue(new List<char>(){'1'});

        while(queue.Count>0){
                List<char> s=queue.Dequeue();
                if(s.Count==n){
                    int sum=0;
                    for(int i=0;i<n;i++){
                        if(s[i]=='1'){
                            sum+=i;
                        }
                    }
                    if(sum<=k)
                    valid.Add(string.Concat(s));
                    continue;
                }
                if(s[s.Count-1]=='1'){
                    s.Add('0');
                    queue.Enqueue(s);
                }
                else{
                    List<char> ls=new List<char>(s);
                    ls.Add('1');
                    s.Add('0');
                    queue.Enqueue(ls);
                    queue.Enqueue(s);
                }
        }
        return valid;
    }
}
