public class Solution {
    
    List<string> happy=new();
    public string GetHappyString(int n, int k) {

        if(k>3*Math.Pow(2,n-1))
        return string.Empty;

        char[] p={'a','b','c'};

        StringBuilder sb=new();
        foreach(var c in p){
            sb.Clear();
            sb.Append(c);
            BackTrack(sb,n-1);
        }
        return happy[k-1];
    }
    private void BackTrack(StringBuilder sb,int n){
        if(n==0){
            happy.Add(sb.ToString());
            return;
        }
        if(sb[^1]=='a'){
           sb.Append('b') ;
           BackTrack(sb,n-1);
           sb.Remove(sb.Length-1,1);
           sb.Append('c');
           BackTrack(sb,n-1);
           sb.Remove(sb.Length-1,1);
        }
        else if(sb[^1]=='b'){
           sb.Append('a') ;
           BackTrack(sb,n-1);
           sb.Remove(sb.Length-1,1);
           sb.Append('c');
           BackTrack(sb,n-1);
            sb.Remove(sb.Length-1,1);
        }
        else{
            sb.Append('a') ;
           BackTrack(sb,n-1);
           sb.Remove(sb.Length-1,1);
           sb.Append('b');
           BackTrack(sb,n-1);
            sb.Remove(sb.Length-1,1);
        }
    }
}
